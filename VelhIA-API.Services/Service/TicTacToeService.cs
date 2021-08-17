using AutoMapper;
using System;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Middlewares.Exceptions;

namespace VelhIA_API.Services.Service
{
    public class TicTacToeService : Service, ITicTacToeService
    {
        private readonly IPlayerMoveRepository playerMoveRepository;
        private readonly IColumnRepository columnRepository;
        private readonly IPlayerRepository playerRepository;

        public TicTacToeService(
            IPlayerMoveRepository playerMoveRepository,
            IColumnRepository columnRepository,
            IPlayerRepository playerRepository,
            IMapper mapper) : base(mapper)
        {
            this.playerMoveRepository = playerMoveRepository;
            this.columnRepository = columnRepository;
            this.playerRepository = playerRepository;
        }

        #region Implemented Methods

        public async Task MoveValidation(Player currentPlayer, Guid playerRequestId, ColumnRequest columnRequest)
        {
            Column column = await columnRepository.GetById(columnRequest.Id.Value);

            if (column.Value != string.Empty)
                throw new ColumnFilledException(
                    Convert<Column, ColumnResponse>(column)
                );

            if (string.IsNullOrEmpty(columnRequest.Value))
                throw new InvalidColumnValueException(columnRequest);

            if (currentPlayer.Id != playerRequestId)
                throw new WrongPlayerMoveException(
                    Convert<Player, PlayerResponse>(await playerRepository.GetById(playerRequestId))
                );
        }

        public async Task MakeMove(Guid columnId, Player currentPlayer)
        {
            Column column = await columnRepository.GetById(columnId);

            await playerMoveRepository.Create(new()
            {
                PlayerId = currentPlayer.Id.Value,
                ColumnId = columnId
            });

            column.Value = currentPlayer.Piece;
            await columnRepository.Edit(column);
        }

        public void MatchValidation(Match match)
        {
            if (match.Players.Count == 0)
                match.AddTwoPlayers();

            else if (match.Players.Count == 1)
                match.AddIAPlayer();

            else if (match.Players.Count != 2)
                throw new IncorrectNumberPlayersException(
                    ConvertCollection<MatchPlayer, MatchPlayerResponse>(match.Players)
                );

            else if (match.IsValidPlayersStarted())
                throw new InvalidPlayersToStartException(
                    ConvertCollection<MatchPlayer, MatchPlayerResponse>(match.Players)
                );

            foreach (MatchPlayer player in match.Players)
            {
                player.Player.ConfigFields();
            }
        }

        #endregion
    }
}

using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Endpoints;
using VelhIA_API.Middlewares.Exceptions;

namespace VelhIA_API.Services.Service
{
    public class TicTacToeService : Service, ITicTacToeService
    {
        private readonly IPlayerMoveRepository playerMoveRepository;

        public TicTacToeService(
            IPlayerMoveRepository playerMoveRepository,
            IMapper mapper) : base(mapper)
        {
            this.playerMoveRepository = playerMoveRepository;
        }

        #region Implemented Methods

        public async Task<DoMoveResponse> DoMove(
            ICollection<Player> players, ColumnRequest columnRequest)
        {
            Player activePlayer = players.First();
            return null;
        }

        public void MatchValidation(Match match)
        {
            if (match.HasZeroPlayers())
            {
                for (int i = 0; i < 2; i++)
                {
                    Player player = new();
                    player.StartPlaying = System.Convert.ToBoolean(i);
                    player.ConfigFields();

                    match.Players.Add(new() { Player = player });
                }
            } else
            {
                if (!match.HasTwoPlayers())
                {
                    throw new IncorrectNumberPlayersException(
                        ConvertCollection<MatchPlayer, MatchPlayerResponse>(match.Players)
                    );
                }

                if (match.IsValidPlayersStarted())
                {
                    throw new InvalidPlayersToStart(
                        ConvertCollection<MatchPlayer, MatchPlayerResponse>(match.Players)
                    );
                }

                foreach (MatchPlayer player in match.Players)
                {
                    player.Player.ConfigFields();
                }
            }
        }

        #endregion

        #region Private Methods

        private bool CheckIsValidMove(Player player, ColumnRequest columnRequest)
        {
            return false;
        }

        #endregion
    }
}

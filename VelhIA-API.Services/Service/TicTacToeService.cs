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

            ConfigPlayers(match);
        }

        #endregion

        #region Private Methods

        private bool CheckIsValidMove(Player player, ColumnRequest columnRequest)
        {
            return false;
        }

        private void ConfigPlayers(Match match)
        {
            foreach (MatchPlayer player in match.Players)
            {
                player.Player.ConfigFields();
            }
        }

        #endregion
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses.Endpoints;
using VelhIA_API.Domain.Structures;

namespace VelhIA_API.Services.Service
{
    public class TicTacToeService : ITicTacToeService
    {
        private readonly IPlayerMoveRepository playerMoveRepository;

        public TicTacToeService(
            IPlayerMoveRepository playerMoveRepository)
        {
            this.playerMoveRepository = playerMoveRepository;
        }

        public Board CreateBoard()
        {
            Board board = new Board();

            for (int i = 0; i < 3; i++)
            {
                Line line = new Line();

                for (int j = 0; j < 3; j++)
                {
                    line.Columns.Add(new Column()
                    {
                        Value = Piece.EMPTY,
                        I = i,
                        J = j
                    });
                }

                board.Lines.Add(line);
            }

            return board;
        }

        public async Task<DoMoveResponse> DoMove(
            ICollection<Player> players, ColumnRequest columnRequest)
        {
            Player activePlayer = players.First();
            return null;
        }

        private bool CheckIsValidMove(Player player, ColumnRequest columnRequest)
        {
            return false;
        }
    }
}

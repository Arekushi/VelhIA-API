using System;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;

namespace VelhIA_API.Application.Services
{
    public interface ITicTacToeService
    {
        void MatchValidation(Match match);

        Task MakeMove(Guid columnId, Player currentPlayer);

        Task MoveValidation(Player currentPlayer, Guid playerRequestId, ColumnRequest columnRequest);
    }
}

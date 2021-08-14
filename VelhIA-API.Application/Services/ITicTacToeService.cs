using System.Collections.Generic;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses.Endpoints;

namespace VelhIA_API.Application.Services
{
    public interface ITicTacToeService
    {
        Board CreateBoard();

        Task<DoMoveResponse> DoMove(
            ICollection<Player> players,
            ColumnRequest columnRequest
        );
    }
}

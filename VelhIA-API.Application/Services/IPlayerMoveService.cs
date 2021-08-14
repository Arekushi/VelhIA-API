using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.Application.Services
{
    public interface IPlayerMoveService :
        IBaseService<PlayerMove, PlayerMoveRequest, PlayerMoveResponse>
    {
        //Task<PlayerMoveResponse> DoMove(ColumnRequest columnRequest, Player player);
    }
}

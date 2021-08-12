using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.Application.Services
{
    public interface IPlayerService : IBaseService<Player, PlayerRequest, PlayerResponse>
    {
    }
}

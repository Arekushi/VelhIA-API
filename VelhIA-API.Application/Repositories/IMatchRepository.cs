using System;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Application.Repositories
{
    public interface IMatchRepository : IBaseRepository<Match>
    {
        Task<Player> GetCurrentPlayer(Guid matchId);

        Task<Player> GetPlayersOrded(Guid matchId);
    }
}

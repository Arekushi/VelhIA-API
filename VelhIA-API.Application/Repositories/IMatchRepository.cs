using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Application.Repositories
{
    public interface IMatchRepository : IBaseRepository<Match>
    {
        Task<(Player, Player)> GetPlayers(Guid matchId);

        Task<ICollection<PlayerMove>> GetMoves(Guid matchId);

        Task<PlayerMove> GetLastMove(Guid matchId);

        Task<bool> AddRound(Guid matchId);
    }
}

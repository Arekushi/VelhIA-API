using VelhIA_API.Application.Repositories;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Data.Context;
using System.Threading.Tasks;
using System;

namespace VelhIA_API.Repositories.Repository
{
    public class MatchRepository : BaseRepository<Match>, IMatchRepository
    {
        public MatchRepository(AppDbContext context) : base(context) { }

        public Task<Player> GetCurrentPlayer(Guid matchId)
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetPlayersOrded(Guid matchId)
        {
            throw new NotImplementedException();
        }
    }
}

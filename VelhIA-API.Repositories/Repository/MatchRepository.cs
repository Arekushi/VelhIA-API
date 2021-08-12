using VelhIA_API.Application.Repositories;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Data.Context;

namespace VelhIA_API.Repositories.Repository
{
    public class MatchRepository : BaseRepository<Match>, IMatchRepository
    {
        public MatchRepository(AppDbContext context) : base(context)
        {
        }
    }
}

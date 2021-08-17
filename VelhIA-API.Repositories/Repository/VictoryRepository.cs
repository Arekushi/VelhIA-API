using VelhIA_API.Application.Repositories;
using VelhIA_API.Data.Context;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Repositories.Repository
{
    public class VictoryRepository : BaseRepository<Victory>, IVictoryRepository
    {
        public VictoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

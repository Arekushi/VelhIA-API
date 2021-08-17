using VelhIA_API.Application.Repositories;
using VelhIA_API.Data.Context;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Repositories.Repository
{
    public class ResultRepository : BaseRepository<Result>, IResultRepository
    {
        public ResultRepository(AppDbContext context) : base(context)
        {
        }
    }
}

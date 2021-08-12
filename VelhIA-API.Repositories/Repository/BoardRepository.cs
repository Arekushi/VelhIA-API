using VelhIA_API.Application.Repositories;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Data.Context;

namespace VelhIA_API.Repositories.Repository
{
    public class BoardRepository : BaseRepository<Board>, IBoardRepository
    {
        public BoardRepository(AppDbContext context) : base(context)
        {
        }
    }
}

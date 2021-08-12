using VelhIA_API.Application.Repositories;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Data.Context;

namespace VelhIA_API.Repositories.Repository
{
    public class PlayerMoveRepository : BaseRepository<PlayerMove>, IPlayerMoveRepository
    {
        public PlayerMoveRepository(AppDbContext context) : base(context)
        {
        }
    }
}

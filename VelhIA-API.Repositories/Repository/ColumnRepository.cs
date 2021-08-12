using VelhIA_API.Application.Repositories;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Data.Context;

namespace VelhIA_API.Repositories.Repository
{
    public class ColumnRepository : BaseRepository<Column>, IColumnRepository
    {
        public ColumnRepository(AppDbContext context) : base(context)
        {
        }
    }
}

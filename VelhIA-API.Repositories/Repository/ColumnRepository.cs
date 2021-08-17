using System;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Data.Context;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Repositories.Repository
{
    public class ColumnRepository : BaseRepository<Column>, IColumnRepository
    {
        public ColumnRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> UpdateValue(string value, Column column)
        {
            try
            {
                column.Value = value;
                await Edit(column);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

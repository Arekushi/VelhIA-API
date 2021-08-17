using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Application.Repositories
{
    public interface IColumnRepository : IBaseRepository<Column>
    {
        Task<bool> UpdateValue(string value, Column column);
    }
}

using System;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;

namespace VelhIA_API.Application.Repositories
{
    public interface IBaseRepository<E> : IDisposable
        where E : Entity
    {
        Task<E> Create(E entity);

        Task<bool> DeleteById(Guid id);

        Task<E> Edit(E entity);

        Task<E> GetById(Guid id);
    }
}

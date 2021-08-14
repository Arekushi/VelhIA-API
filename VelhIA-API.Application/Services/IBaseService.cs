using System;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.Application.Services
{
    public interface IBaseService<E, R, P>
        where E : Entity
        where R : EntityRequest
        where P : EntityResponse
    {
        Task<P> Create(R request);

        Task<bool> DeleteById(Guid id);

        Task<P> GetById(Guid id);

        Task<P> Edit(R request);
    }
}

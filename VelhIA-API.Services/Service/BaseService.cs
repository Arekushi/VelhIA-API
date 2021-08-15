using AutoMapper;
using System;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Middlewares.Exceptions;

namespace VelhIA_API.Services.Service
{
    public class BaseService<E, R, P> : Service, IBaseService<E, R, P>
        where E : Entity
        where R : EntityRequest
        where P : EntityResponse
    {
        protected readonly IBaseRepository<E> repository;

        public BaseService(
            IBaseRepository<E> repository,
            IMapper mapper) : base(mapper)
        {
            this.repository = repository;
        }

        #region Implemented Methods

        public virtual async Task<P> Create(R request)
        {
            E entity = RequestToEntity(request);
            E result = await repository.Create(entity);

            return EntityToResponse(result);
        }

        public virtual async Task<bool> DeleteById(Guid id)
        {
            bool result = await repository.DeleteById(id);
            return result;
        }

        public virtual async Task<P> Edit(R request)
        {
            E entity = RequestToEntity(request);
            E result = await repository.Edit(entity);

            return EntityToResponse(result);
        }

        public virtual async Task<P> GetById(Guid id)
        {
            E entity = await repository.GetById(id);

            if (entity != null)
            {
                return EntityToResponse(entity);
            }

            throw new RegisterNotFoundException(typeof(E).Name, id);
        }

        #endregion

        #region Parse Methods

        protected E RequestToEntity(R request)
        {
            return mapper.Map<E>(request);
        }

        protected R EntityToRequest(E entity)
        {
            return mapper.Map<R>(entity);
        }

        protected P EntityToResponse(E entity)
        {
            return mapper.Map<P>(entity);
        }

        protected E ResponseToEntity(P response)
        {
            return mapper.Map<E>(response);
        }

        #endregion
    }
}

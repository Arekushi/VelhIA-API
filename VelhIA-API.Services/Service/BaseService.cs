using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.Services.Service
{
    public class BaseService<E, R, P> : IBaseService<E, R, P>
        where E : Entity
        where R : EntityRequest
        where P : EntityResponse
    {
        protected readonly IBaseRepository<E> repository;
        protected readonly IMapper mapper;

        public BaseService(
            IBaseRepository<E> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

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

        public virtual async Task<P> EditById(R request, Guid id)
        {
            E entity = RequestToEntity(request);
            E result = await repository.Edit(entity);

            return EntityToResponse(result);
        }

        public virtual async Task<P> GetById(Guid id)
        {
            E entity = await repository.GetById(id);
            P response = EntityToResponse(entity);

            return response;
        }

        protected E RequestToEntity(R request)
        {
            return mapper.Map<E>(request);
        }

        protected P EntityToResponse(E entity)
        {
            return mapper.Map<P>(entity);
        }

        protected ICollection<G> ConvertCollection<F, G>(ICollection<F> from)
        {
            return mapper.Map<ICollection<F>, ICollection<G>>(from);
        }
    }
}

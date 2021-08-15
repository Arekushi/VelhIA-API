using AutoMapper;
using System.Collections.Generic;
using VelhIA_API.Application.Services;

namespace VelhIA_API.Services.Service
{
    public class Service : IService
    {
        protected readonly IMapper mapper;

        public Service(IMapper mapper)
        {
            this.mapper = mapper;
        }

        #region Parse Methods

        public G Convert<F, G>(F from)
        {
            return mapper.Map<F, G>(from);
        }

        public ICollection<G> ConvertCollection<F, G>(ICollection<F> from)
        {
            return mapper.Map<ICollection<F>, ICollection<G>>(from);
        }

        #endregion
    }
}

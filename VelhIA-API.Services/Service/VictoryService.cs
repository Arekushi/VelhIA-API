using AutoMapper;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.Services.Service
{
    public class VictoryService :
        BaseService<Victory, VictoryRequest, VictoryResponse>, IVictoryService
    {
        public VictoryService(
            IVictoryRepository repository,
            IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

using AutoMapper;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.Services.Service
{
    public class ColumnService :
        BaseService<Column, ColumnRequest, ColumnResponse>, IColumnService
    {
        public ColumnService(
            IColumnRepository repository,
            IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

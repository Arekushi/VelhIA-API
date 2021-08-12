using Microsoft.AspNetCore.Mvc;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.API.Controllers
{
    [Route("api/column")]
    [ApiController]
    public class ColumnController : BaseController<Column, ColumnRequest, ColumnResponse>
    {
        public ColumnController(
            IColumnService service) : base(service)
        {
        }
    }
}

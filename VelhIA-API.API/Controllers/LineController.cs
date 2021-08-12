using Microsoft.AspNetCore.Mvc;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.API.Controllers
{
    [Route("api/line")]
    [ApiController]
    public class LineController :
        BaseController<Line, LineRequest, LineResponse>
    {
        public LineController(
            ILineService service) : base(service)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.API.Controllers
{
    [Route("api/match")]
    [ApiController]
    public class MatchController :
        BaseController<Match, MatchRequest, MatchResponse>
    {
        public MatchController(
            IMatchService service) : base(service)
        {
        }
    }
}

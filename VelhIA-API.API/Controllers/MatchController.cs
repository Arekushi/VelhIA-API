using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Requests.Endpoints;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.API.Controllers
{
    [Route("api/match")]
    [ApiController]
    public class MatchController :
        BaseController<Match, MatchRequest, MatchResponse>
    {
        private readonly new IMatchService service;

        public MatchController(
            IMatchService service) : base(service)
        {
            this.service = service;
        }

        [HttpPost("create-match")]
        public async Task<IActionResult> CreateMatch(MatchRequest request)
        {
            var response = await service.CreateMatch(request);
            return Ok(response);
        }

        [HttpPost("make-move")]
        public async Task<IActionResult> MakeMove(MakeMoveRequest request)
        {
            var response = await service.MakeMove(request);
            return Ok(response);
        }
    }
}

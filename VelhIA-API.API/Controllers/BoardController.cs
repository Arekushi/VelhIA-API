using Microsoft.AspNetCore.Mvc;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.API.Controllers
{
    [Route("api/board")]
    [ApiController]
    public class BoardController :
        BaseController<Board, BoardRequest, BoardResponse>
    {
        public BoardController(
            IBoardService service) : base(service)
        {
        }
    }
}

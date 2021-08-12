﻿using Microsoft.AspNetCore.Mvc;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.API.Controllers
{
    [Route("api/player-move")]
    [ApiController]
    public class PlayerMoveController :
        BaseController<PlayerMove, PlayerMoveRequest, PlayerMoveResponse>
    {
        public PlayerMoveController(
            IPlayerMoveService service) : base(service)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VelhIA_API.Application.Controllers;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<E, R, P> : ControllerBase, IBaseController<E, R>
        where E : Entity
        where R : EntityRequest
        where P : EntityResponse
    {
        protected IBaseService<E, R, P> service;

        public BaseController(
            IBaseService<E, R, P> service)
        {
            this.service = service;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(Guid id)
        {
            var response = await service.DeleteById(id);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await service.GetById(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(R request)
        {
            var response = await service.Create(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(R request)
        {
            var response = await service.Edit(request);
            return Ok(response);
        }
    }
}

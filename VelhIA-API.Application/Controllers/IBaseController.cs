using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;

namespace VelhIA_API.Application.Controllers
{
    public interface IBaseController<E, R>
        where E : Entity
        where R : EntityRequest
    {
        Task<IActionResult> GetById(Guid id);

        Task<IActionResult> Post(R request);

        Task<IActionResult> DeleteById(Guid id);

        Task<IActionResult> Put(R request);
    }
}

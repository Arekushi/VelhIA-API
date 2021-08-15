using System;
using System.Net;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class RegisterNotFoundException : BaseException
    {
        public RegisterNotFoundException(string entity, Guid id)
        {
            Code = HttpStatusCode.NotFound;
            Response = new ExceptionResponse<string>()
            {
                Success = false,
                Code = Code,
                ExceptionName = nameof(RegisterNotFoundException),
                Message = $"O registro na entidade ({entity}), de ID ({id}) não existe!"
            };
        }
    }
}

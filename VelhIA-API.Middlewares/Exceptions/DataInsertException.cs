using System.Net;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class DataInsertException : BaseException
    {
        public DataInsertException(string entity, object e = null)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<object>()
            {
                Code = Code,
                Success = false,
                ExceptionName = nameof(DataInsertException),
                Message = $"Não foi possível criar uma instância de {entity}",
                Data = e
            };
        }
    }
}

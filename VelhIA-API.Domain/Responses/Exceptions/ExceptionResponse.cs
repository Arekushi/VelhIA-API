using System.Net;
using VelhIA_API.Domain.Responses.Endpoints;

namespace VelhIA_API.Domain.Responses.Exceptions
{
    public class ExceptionResponse<T> : Endpoints.DefaultResponse<T> 
        where T : class
    {
        public ExceptionResponse() { }

        public string ExceptionName { get; set; }
    }
}

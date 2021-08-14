using Newtonsoft.Json;
using System.Net;

namespace VelhIA_API.Domain.Responses.Exceptions
{
    public class ExceptionResponse<T>
    {
        public HttpStatusCode Code { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public T Object { get; set; }
    }
}

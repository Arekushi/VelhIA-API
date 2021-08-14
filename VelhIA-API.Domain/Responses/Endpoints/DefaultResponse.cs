using System.Net;

namespace VelhIA_API.Domain.Responses.Endpoints
{
    public class DefaultResponse<T>
        where T : class
    {
        public DefaultResponse(
            T data = null,
            string message = null,
            HttpStatusCode code = HttpStatusCode.OK)
        {
            Success = true;
            Code = code;
            Data = data;
            Message = message;
        }

        public HttpStatusCode Code { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }
}

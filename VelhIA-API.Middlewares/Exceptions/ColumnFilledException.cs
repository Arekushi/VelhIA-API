using System.Net;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class ColumnFilledException : BaseException
    {
        public ColumnFilledException(ColumnResponse column)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<ColumnResponse>()
            {
                Success = false,
                Code = Code,
                Data = column,
                ExceptionName = nameof(ColumnFilledException),
                Message = $"A coluna já está preenchida, não há jogadas possíveis"
            };
        }
    }
}

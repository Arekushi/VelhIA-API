using System.Net;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class InvalidColumnValueException : BaseException
    {
        public InvalidColumnValueException(ColumnRequest column)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<ColumnRequest>()
            {
                Success = false,
                Code = Code,
                Data = column,
                ExceptionName = nameof(InvalidColumnValueException),
                Message = "O valor da coluna deve ser 'X' ou 'O'",
            };
        }
    }
}

using System.Net;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class InvalidColumnValueException : BaseException
    {
        public InvalidColumnValueException(ColumnResponse column)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<ColumnResponse>()
            {
                Success = false,
                Code = Code,
                Object = column,
                Message = "O valor da coluna deve ser 'X' ou 'O'",
            };
        }
    }
}

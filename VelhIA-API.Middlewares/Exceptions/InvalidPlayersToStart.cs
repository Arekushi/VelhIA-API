using System.Collections.Generic;
using System.Net;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class InvalidPlayersToStart : BaseException
    {
        public InvalidPlayersToStart(ICollection<MatchPlayerResponse> players)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<ICollection<MatchPlayerResponse>>()
            {
                Success = false,
                Code = Code,
                ExceptionName = nameof(InvalidPlayersToStart),
                Message = $"Valor inválido de jogadores para começar!",
                Data = players
            };
        }
    }
}

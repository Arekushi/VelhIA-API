using System.Collections.Generic;
using System.Net;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class IncorrectNumberPlayersException : BaseException
    {
        public IncorrectNumberPlayersException(ICollection<MatchPlayerResponse> players)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<ICollection<MatchPlayerResponse>>()
            {
                Success = false,
                Code = Code,
                ExceptionName = nameof(IncorrectNumberPlayersException),
                Message = $"Número incorreto de players ({players.Count})! " +
                          $"É necessário apenas 2 players para criar uma partida válida.",
                Data = players
            };
        }
    }
}

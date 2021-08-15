using System.Collections.Generic;
using System.Net;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class InvalidPlayersToStartException : BaseException
    {
        public InvalidPlayersToStartException(ICollection<MatchPlayerResponse> players)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<ICollection<MatchPlayerResponse>>()
            {
                Success = false,
                Code = Code,
                ExceptionName = nameof(InvalidPlayersToStartException),
                Message = $"Valor inválido de jogadores que começam a jogar!",
                Data = players
            };
        }
    }
}

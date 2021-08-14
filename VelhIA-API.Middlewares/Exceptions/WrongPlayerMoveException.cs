using System.Net;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Exceptions;

namespace VelhIA_API.Middlewares.Exceptions
{
    public class WrongPlayerMoveException : BaseException
    {
        public WrongPlayerMoveException(PlayerResponse player)
        {
            Code = HttpStatusCode.BadRequest;
            Response = new ExceptionResponse<PlayerResponse>()
            {
                Success = false,
                Code = Code,
                Object = player,
                Message = $"Não é a vez do jogador {player.Name} jogar, espere sua vez, seu ladrãozinho >:("
            };
        }
    }
}

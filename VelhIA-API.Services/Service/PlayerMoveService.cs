using AutoMapper;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Responses;

namespace VelhIA_API.Services.Service
{
    public class PlayerMoveService :
        BaseService<PlayerMove, PlayerMoveRequest, PlayerMoveResponse>, IPlayerMoveService
    {
        public PlayerMoveService(
            IPlayerMoveRepository repository,
            IMapper mapper) : base(repository, mapper)
        {
        }

        //public async Task<PlayerMoveResponse> DoMove(ColumnRequest columnRequest, Player player)
        //{
        //    var response = await columnService.Edit(columnRequest);

        //    PlayerMove playerMove = new PlayerMove()
        //    {
        //        Column = Convert<ColumnResponse, Column>(response),
        //        Player = player
        //    };

        //    return EntityToResponse(await repository.Create(playerMove));
        //}
    }
}

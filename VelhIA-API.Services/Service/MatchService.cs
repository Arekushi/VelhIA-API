using AutoMapper;
using System;
using System.Threading.Tasks;
using VelhIA_API.Application.Repositories;
using VelhIA_API.Application.Services;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Requests.Endpoints;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Endpoints;

namespace VelhIA_API.Services.Service
{
    public class MatchService :
        BaseService<Match, MatchRequest, MatchResponse>, IMatchService
    {
        private readonly ITicTacToeService ticTacToeService;
        private readonly new IMatchRepository repository;

        public MatchService(
            IMatchRepository repository,
            ITicTacToeService ticTacToeService,
            IMapper mapper) : base(repository, mapper)
        {
            this.ticTacToeService = ticTacToeService;
            this.repository = repository;
        }

        public async Task<MatchResponse> CreateMatch(MatchRequest request)
        {
            try
            {
                Match match = RequestToEntity(request);
                ticTacToeService.MatchValidation(match);

                match = await repository.Create(match);
                return EntityToResponse(match);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MakeMoveResponse> MakeMove(MakeMoveRequest request)
        {
            (Player current, Player next) = await repository.GetPlayers(request.MatchId);

            await ticTacToeService.MoveValidation(current, request.PlayerId, request.Column);
            await ticTacToeService.MakeMove(request.Column.Id.Value, current);
            await repository.AddRound(request.MatchId);

            return new()
            {
                Success = true,
                NextToPlay = Convert<Player, PlayerResponse>(next)
            };
        }
    }
}

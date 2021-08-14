using AutoMapper;
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
    public class MatchService : BaseService<Match, MatchRequest, MatchResponse>, IMatchService
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
            Match match = RequestToEntity(request);
            match.Board = ticTacToeService.CreateBoard();

            return EntityToResponse(await repository.Create(match));
        }

        public async Task<DoMoveResponse> DoMove(DoMoveRequest request)
        {
            //Player player = await repository.GetCurrentPlayer(request.MatchId);
            //return await ticTacToeService.DoMove(null, request.Column);
            return null;
        }
    }
}

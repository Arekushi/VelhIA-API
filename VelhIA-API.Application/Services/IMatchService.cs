using System.Threading.Tasks;
using VelhIA_API.Domain.Entities;
using VelhIA_API.Domain.Requests;
using VelhIA_API.Domain.Requests.Endpoints;
using VelhIA_API.Domain.Responses;
using VelhIA_API.Domain.Responses.Endpoints;

namespace VelhIA_API.Application.Services
{
    public interface IMatchService : IBaseService<Match, MatchRequest, MatchResponse>
    {
        Task<MatchResponse> CreateMatch(MatchRequest request);

        Task<DoMoveResponse> DoMove(DoMoveRequest request);
    }
}

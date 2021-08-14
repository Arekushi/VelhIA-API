using System.Collections.Generic;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Responses
{
    public class MatchResponse : EntityResponse
    {
        public MatchResponse()
        {
            Players = new List<MatchPlayerResponse>();
        }

        public MatchType Type { get; set; }

        public ICollection<MatchPlayerResponse> Players { get; set; }

        public BoardResponse Board { get; set; }
    }
}

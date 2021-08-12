using System;

namespace VelhIA_API.Domain.Responses
{
    public class MatchPlayerResponse : EntityResponse
    {
        public Guid PlayerId { get; set; }

        public PlayerResponse Player { get; set; }

        public Guid MatchId { get; set; }

        public MatchResponse Match { get; set; }
    }
}

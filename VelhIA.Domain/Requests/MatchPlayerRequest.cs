using System;

namespace VelhIA_API.Domain.Requests
{
    public class MatchPlayerRequest : EntityRequest
    {
        public Guid PlayerId { get; set; }

        public PlayerRequest Player { get; set; }

        public Guid MatchId { get; set; }

        public MatchRequest Match { get; set; }
    }
}

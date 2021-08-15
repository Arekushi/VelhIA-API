using System;

namespace VelhIA_API.Domain.Requests
{
    public class ResultRequest : EntityRequest
    {
        public PlayerMoveRequest LastMove { get; set; }

        public int Moves { get; set; }

        public TimeSpan MatchTime { get; set; }

        public MatchRequest Match { get; set; }

        public Guid MatchId { get; set; }

        public VictoryRequest Victory { get; set; }
    }
}

using System;

namespace VelhIA_API.Domain.Requests.Endpoints
{
    public class MakeMoveRequest
    {
        public Guid MatchId { get; set; }

        public Guid PlayerId { get; set; }

        public ColumnRequest Column { get; set; }
    }
}

using System;

namespace VelhIA_API.Domain.Requests.Endpoints
{
    public class DoMoveRequest
    {
        public Guid MatchId { get; set; }

        public ColumnRequest Column { get; set; }
    }
}

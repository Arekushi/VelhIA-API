using System;

namespace VelhIA_API.Domain.Requests
{
    public class PlayerMoveRequest : EntityRequest
    {
        public Guid PlayerId { get; set; }

        public PlayerRequest Player { get; set; }

        public Guid ColumnId { get; set; }

        public ColumnRequest Column { get; set; }
    }
}

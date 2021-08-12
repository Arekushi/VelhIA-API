using System;

namespace VelhIA_API.Domain.Responses
{
    public class PlayerMoveResponse : EntityResponse
    {
        public Guid PlayerId { get; set; }

        public PlayerResponse Player { get; set; }

        public Guid ColumnId { get; set; }

        public ColumnResponse Column { get; set; }
    }
}

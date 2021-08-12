using System;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Responses
{
    public class ColumnResponse : EntityResponse
    {
        public Piece? Value { get; set; }

        public Guid LineId { get; set; }

        public LineResponse Line { get; set; }
    }
}

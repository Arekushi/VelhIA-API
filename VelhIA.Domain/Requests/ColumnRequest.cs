using System;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Requests
{
    public class ColumnRequest : EntityRequest
    {
        public Piece? Value { get; set; }
        public Guid LineId { get; set; }
        public LineRequest Line { get; set; }
    }
}

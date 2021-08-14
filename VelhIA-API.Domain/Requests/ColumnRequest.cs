using System;

namespace VelhIA_API.Domain.Requests
{
    public class ColumnRequest : EntityRequest
    {
        public string Value { get; set; }

        public int I { get; set; }

        public int J { get; set; }

        public Guid LineId { get; set; }

        public LineRequest Line { get; set; }
    }
}

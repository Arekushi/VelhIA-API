using System;
using System.Collections.Generic;

namespace VelhIA_API.Domain.Responses
{
    public class LineResponse : EntityResponse
    {
        public LineResponse()
        {
            Columns = new List<ColumnResponse>();
        }

        public Guid BoardId { get; set; }

        public BoardResponse Board { get; set; }

        public ICollection<ColumnResponse> Columns { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace VelhIA_API.Domain.Requests
{
    public class LineRequest : EntityRequest
    {
        public LineRequest()
        {
            Columns = new List<ColumnRequest>();
        }

        public Guid BoardId { get; set; }
        public BoardRequest Board { get; set; }
        public ICollection<ColumnRequest> Columns { get; set; }
    }
}

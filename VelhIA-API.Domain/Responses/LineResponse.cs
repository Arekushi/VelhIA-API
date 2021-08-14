using Newtonsoft.Json;
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

        [JsonIgnore]
        public Guid BoardId { get; set; }

        [JsonIgnore]
        public BoardResponse Board { get; set; }

        public ICollection<ColumnResponse> Columns { get; set; }
    }
}

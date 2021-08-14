using Newtonsoft.Json;
using System;

namespace VelhIA_API.Domain.Responses
{
    public class ColumnResponse : EntityResponse
    {
        public string Value { get; set; }

        public int I { get; set; }

        public int J { get; set; }

        [JsonIgnore]
        public Guid LineId { get; set; }

        [JsonIgnore]
        public LineResponse Line { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VelhIA_API.Domain.Responses
{
    public class BoardResponse : EntityResponse
    {
        public BoardResponse()
        {
            Lines = new List<LineResponse>();
        }

        public ICollection<LineResponse> Lines { get; set; }

        [JsonIgnore]
        public MatchResponse Match { get; set; }

        [JsonIgnore]
        public Guid? MatchId { get; set; }
    }
}

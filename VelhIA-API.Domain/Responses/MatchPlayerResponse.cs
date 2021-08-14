using Newtonsoft.Json;
using System;

namespace VelhIA_API.Domain.Responses
{
    public class MatchPlayerResponse
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Guid PlayerId { get; set; }

        public PlayerResponse Player { get; set; }

        [JsonIgnore]
        public Guid MatchId { get; set; }

        public MatchResponse Match { get; set; }
    }
}

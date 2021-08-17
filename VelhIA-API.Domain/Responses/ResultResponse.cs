using Newtonsoft.Json;
using System;

namespace VelhIA_API.Domain.Responses
{
    public class ResultResponse : EntityResponse
    {
        public PlayerMoveResponse LastMove { get; set; }

        public int Moves { get; set; }

        public TimeSpan MatchTime { get; set; }

        [JsonIgnore]
        public MatchResponse Match { get; set; }

        public VictoryResponse Victory { get; set; }
    }
}

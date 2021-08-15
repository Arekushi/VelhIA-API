using Newtonsoft.Json;
using System.Collections.Generic;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Responses
{
    public class PlayerResponse : EntityResponse
    {
        public PlayerResponse()
        {
            Matches = new List<MatchPlayerResponse>();
        }

        public string Name { get; set; }

        public PlayerType Type { get; set; }

        public AlgorithmType? AlgorithmType { get; set; }

        public string Piece { get; set; }

        public bool StartPlaying { get; set; }

        [JsonIgnore]
        public ICollection<MatchPlayerResponse> Matches { get; set; }
    }
}

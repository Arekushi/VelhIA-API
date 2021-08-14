using System.Collections.Generic;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Requests
{
    public class PlayerRequest : EntityRequest
    {
        public PlayerRequest()
        {
            Matches = new List<MatchPlayerRequest>();
        }

        public string Name { get; set; }

        public PlayerType Type { get; set; }

        public AlgoritmType? AlgoritmType { get; set; }

        public string Piece { get; set; }

        public bool StartPlaying { get; set; }

        public ICollection<MatchPlayerRequest> Matches { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace VelhIA_API.Domain.Requests
{
    public class MatchRequest : EntityRequest
    {
        public MatchRequest()
        {
            Players = new List<MatchPlayerRequest>();
        }

        public ICollection<MatchPlayerRequest> Players { get; set; }

        public Guid? BoardId { get; set; }

        public BoardRequest Board { get; set; }
    }
}

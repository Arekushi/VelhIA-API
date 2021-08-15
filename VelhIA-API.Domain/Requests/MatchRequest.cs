using System;
using System.Collections.Generic;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Requests
{
    public class MatchRequest : EntityRequest
    {
        public MatchRequest()
        {
            Players = new List<MatchPlayerRequest>();
        }

        public MatchType Type { get; set; }

        public ICollection<MatchPlayerRequest> Players { get; set; }
    }
}

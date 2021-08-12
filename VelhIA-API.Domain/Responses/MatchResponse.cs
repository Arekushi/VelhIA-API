using System;
using System.Collections.Generic;

namespace VelhIA_API.Domain.Responses
{
    public class MatchResponse : EntityResponse
    {
        public MatchResponse()
        {
            Players = new List<MatchPlayerResponse>();
        }

        public ICollection<MatchPlayerResponse> Players { get; set; }

        public Guid? BoardId { get; set; }

        public BoardResponse Board { get; set; }
    }
}

using System;

namespace VelhIA_API.Domain.Requests
{
    public class VictoryRequest : EntityRequest
    {
        public string Type { get; set; }

        public ResultRequest Result { get; set; }

        public Guid ResultId { get; set; }

        public PlayerRequest Winner { get; set; }

        public Guid WinnerId { get; set; }

        public PlayerRequest Loser { get; set; }

        public Guid LoserId { get; set; }
    }
}

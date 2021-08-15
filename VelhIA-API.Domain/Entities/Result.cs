using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    [Table(nameof(Result))]
    public class Result : Entity
    {
        public PlayerMove LastMove { get; set; }

        public int Moves { get; set; }

        public TimeSpan MatchTime { get; set; }

        public Match Match { get; set; }

        public Guid MatchId { get; set; }

        public Victory Victory { get; set; }
    }
}

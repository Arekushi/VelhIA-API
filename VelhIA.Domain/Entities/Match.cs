using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    [Table("Match")]
    public class Match : Entity
    {
        public Match()
        {
            Players = new List<MatchPlayer>();
        }

        public ICollection<MatchPlayer> Players { get; set; }

        public Guid? BoardId { get; set; }

        public Board Board { get; set; }
    }
}

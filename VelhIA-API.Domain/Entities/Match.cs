using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Entities
{
    [Table("Match")]
    public class Match : Entity
    {
        public Match()
        {
            Players = new List<MatchPlayer>();
        }

        public MatchType Type { get; set; }

        public ICollection<MatchPlayer> Players { get; set; }

        public Board Board { get; set; }
    }
}

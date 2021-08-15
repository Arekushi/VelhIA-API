using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    [Table("Match_Player")]
    public class MatchPlayer : Entity
    {
        [NotMapped]
        public new Guid Id { get; set; }

        public Guid PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }

        public Guid MatchId { get; set; }

        [ForeignKey(nameof(MatchId))]
        public Match Match { get; set; }
    }
}

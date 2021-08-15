using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    [Table(nameof(Victory))]
    public class Victory : Entity
    {
        public string Type { get; set; }

        public Result Result { get; set; }

        public Guid ResultId { get; set; }

        public Player Winner { get; set; }

        [ForeignKey(nameof(Winner))]
        public Guid WinnerId { get; set; }

        public Player Loser { get; set; }

        [ForeignKey(nameof(Loser))]
        public Guid LoserId { get; set; }
    }
}

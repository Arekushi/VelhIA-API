using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    [Table("Board")]
    public class Board : Entity
    {
        public Board()
        {
            Lines = new List<Line>();
        }

        public ICollection<Line> Lines { get; set; }

        public Match Match { get; set; }

        public Guid? MatchId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    [Table(nameof(Line))]
    public class Line : Entity
    {
        public Line()
        {
            Columns = new List<Column>();
        }

        public Guid BoardId { get; set; }

        [ForeignKey(nameof(BoardId))]
        public Board Board { get; set; }

        public ICollection<Column> Columns { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using VelhIA_API.Domain.Structures;

namespace VelhIA_API.Domain.Entities
{
    [Table("Column")]
    public class Column : Entity
    {
        public Column()
        {
            Value = Piece.EMPTY;
        }

        public string Value { get; set; }

        public int I { get; set; }

        public int J { get; set; }

        public Guid LineId { get; set; }

        [ForeignKey(nameof(LineId))]
        public Line Line { get; set; }
    }
}

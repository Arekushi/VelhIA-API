using System;
using System.ComponentModel.DataAnnotations.Schema;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Entities
{
    [Table("Column")]
    public class Column : Entity
    {
        public Piece? Value { get; set; }

        public Guid LineId { get; set; }

        [ForeignKey(nameof(LineId))]
        public Line Line { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    [Table("PlayerMove")]
    public class PlayerMove : Entity
    {
        public Guid PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }

        public Guid ColumnId { get; set; }

        [ForeignKey(nameof(ColumnId))]
        public Column Column { get; set; }
    }
}

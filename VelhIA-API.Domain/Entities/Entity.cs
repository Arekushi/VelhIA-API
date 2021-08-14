using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelhIA_API.Domain.Entities
{
    public abstract class Entity
    {
        [Key]
        [Required]
        [Column("Id", TypeName = "VARCHAR(255)")]
        public Guid? Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool Enabled { get; set; }
    }
}

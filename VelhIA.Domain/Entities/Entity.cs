using System;

namespace VelhIA_API.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool Enabled { get; set; }
    }
}

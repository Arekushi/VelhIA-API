using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Entities
{
    [Table("Player")]
    public class Player : Entity
    {
        public Player()
        {
            Matches = new List<MatchPlayer>();
        }

        public string Name { get; set; }

        public PlayerType Type { get; set; }

        public AlgoritmType? AlgoritmType { get; set; }

        public string Piece { get; set; }

        public bool StartPlaying { get; set; }

        public ICollection<MatchPlayer> Matches { get; set; }
    }
}

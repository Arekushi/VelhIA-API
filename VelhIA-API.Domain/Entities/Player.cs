using NameGenerator.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            realNameGenerator = new();
            random = new();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public PlayerType Type { get; set; }

        public AlgoritmType? AlgoritmType { get; set; }

        public string Piece { get; set; }

        public bool StartPlaying { get; set; }

        public ICollection<MatchPlayer> Matches { get; set; }

        [NotMapped]
        private readonly RealNameGenerator realNameGenerator;

        [NotMapped]
        private readonly Random random;

        public override void ConfigFields()
        {
            AlgoritmType ??= SetAlgoritmType();
            Name ??= SetName();
            Piece ??= SetPiece();
        }

        private string SetName()
        {
            return Type switch
            {
                PlayerType.COMPUTER => $"IA-{AlgoritmType}",
                _ => $"{realNameGenerator.Generate().Split(' ')[0]}#" +
                    $"{random.Next(0, 9999):0000}"
            };
        }

        private string SetPiece()
        {
            return StartPlaying ?
                Structures.Piece.CROSS : Structures.Piece.CIRCLE;
        }

        private AlgoritmType? SetAlgoritmType()
        {
            if (Type is PlayerType.COMPUTER)
            {
                return Enums.AlgoritmType.MINIMAX;
            }

            return null;
        }
    }
}

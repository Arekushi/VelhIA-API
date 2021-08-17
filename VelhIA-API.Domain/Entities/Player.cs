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
            Moves = new List<PlayerMove>();
            realNameGenerator = new();
            random = new();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public PlayerType Type { get; set; }

        public AlgorithmType? AlgorithmType { get; set; }

        public string Piece { get; set; }

        public bool StartPlaying { get; set; }

        public ICollection<MatchPlayer> Matches { get; set; }

        public ICollection<PlayerMove> Moves { get; set; }

        [NotMapped]
        private readonly RealNameGenerator realNameGenerator;

        [NotMapped]
        private readonly Random random;

        public override void ConfigFields()
        {
            AlgorithmType ??= SetAlgoritmType();
            Name ??= SetName();
            Piece ??= SetPiece();
        }

        private string SetName()
        {
            return Type switch
            {
                PlayerType.COMPUTER => $"IA-{AlgorithmType}",
                _ => $"{realNameGenerator.Generate().Split(' ')[0]}#" +
                    $"{random.Next(0, 9999):0000}"
            };
        }

        private string SetPiece()
        {
            return StartPlaying ?
                Structures.Piece.CROSS : Structures.Piece.CIRCLE;
        }

        private AlgorithmType? SetAlgoritmType()
        {
            if (Type is PlayerType.COMPUTER)
            {
                return Enums.AlgorithmType.MINIMAX;
            }

            return null;
        }
    }
}

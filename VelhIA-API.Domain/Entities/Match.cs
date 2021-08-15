using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using VelhIA_API.Domain.Enums;

namespace VelhIA_API.Domain.Entities
{
    [Table("Match")]
    public class Match : Entity
    {
        public Match()
        {
            Players = new List<MatchPlayer>();
            Board = new Board();
        }

        public MatchType Type { get; set; }

        public ICollection<MatchPlayer> Players { get; set; }

        public Board Board { get; set; }

        public bool HasZeroPlayers()
        {
            return Players.Count == 0;
        }

        public bool HasTwoPlayers()
        {
            return Players.Count == 2;
        }

        public bool IsValidPlayersStarted()
        {
            bool started = Players
                .Where(p => p.Player.StartPlaying)
                .Count() != 1;

            return started;
        }
    }
}

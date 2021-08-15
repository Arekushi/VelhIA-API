using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using VelhIA_API.Domain.Structures;

namespace VelhIA_API.Domain.Entities
{
    [Table("Board")]
    public class Board : Entity
    {
        public Board()
        {
            Lines = new List<Line>();
            Init();
        }

        public Board(int lines, int columns)
        {
            Lines = new List<Line>();
            Init(lines, columns);
        }

        public ICollection<Line> Lines { get; set; }

        public Match Match { get; set; }

        public Guid? MatchId { get; set; }

        private void Init(
            int lines = 3,
            int columns = 3)
        {
            for (int i = 0; i < lines; i++)
            {
                Line line = new();

                for (int j = 0; j < columns; j++)
                {
                    line.Columns.Add(new()
                    {
                        Value = Piece.EMPTY,
                        I = i,
                        J = j
                    });
                }

                Lines.Add(line);
            }
        }
    }
}

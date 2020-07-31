using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.Models
{
    public abstract class Piece
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string PositionX { get; set; }
        public abstract string PositionY { get; set; } // (1, a)
        public abstract string Color { get; set; }
        public abstract bool Dead { get; set; }
        public abstract string Img { get; set; }
    }
}

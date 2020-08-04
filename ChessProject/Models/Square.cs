using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.Models
{
    public class Square
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionX { get; set; }
        public string PositionY { get; set; } // (1, a)
        public string Color { get; set; } //light or dark
        public bool Empty { get; set; }

        public string ImgPiece { get; set; }

        public int PieceId { get; set; }
        public Piece Piece { get; set; }
    }
}

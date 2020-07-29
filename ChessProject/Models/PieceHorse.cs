using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.Models
{
    public class PieceHorse : Piece
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string PositionX { get; set; }
        public override string PositionY { get; set; }
        public override string Color { get; set; }
        public override bool Dead { get; set; }
    }

}

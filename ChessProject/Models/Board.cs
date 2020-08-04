using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.Models
{
    public class Board
    {
        public int Id { get; set; }
        public List<Square> Squares { get; set; }
        public List<Piece> Pieces { get; set; }
    }
}

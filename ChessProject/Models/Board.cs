using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.Models
{
    public class Board
    {
        public int Id { get; set; }
        public ICollection<Square> Squares { get; set; }
        public ICollection<Piece> Pieces { get; set; }
    }
}

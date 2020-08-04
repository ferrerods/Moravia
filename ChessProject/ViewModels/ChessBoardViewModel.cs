using ChessProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.ViewModels
{
    public class ChessBoardViewModel
    {
        public List<Square> Squares { get; set; }
        public Piece Pieces { get; set; }
    }
}

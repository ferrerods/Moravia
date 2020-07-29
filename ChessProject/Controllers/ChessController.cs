using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.Logging;

namespace ChessProject.Controllers
{
    public class ChessController : Controller
    {
        private const int nroSquare = 64;
        private const int nroPiece = 32;
        private const int nroColumn = 8;
        private string[] Row = { "a", "b", "c", "d", "e", "f", "h" };
        private string colorSquareD = "dark";
        private string colorSquareL = "light";
        private string colorSquare = "dark";
        private string colorB = "Black";
        private string colorW = "White";

        public IActionResult Index()
        {
            Initialize();
            RandomPiece();
            return View();
        }
        private void Initialize()
        {
            Game game = new Game{
                
            };
            

        }
        private void RandomPiece()
        {
        }

    }
}

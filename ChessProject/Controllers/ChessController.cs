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
        public IActionResult Index()
        {
            Initialize();
            RandomPiece();
            return View();
        }

        public ActionResult NewGame() {
            return View(); //FALTA
        }
        private void Initialize()
        {
            Board newBoard = new BoardsController().Initialize();

            Chess newChess = new Chess
            {
                Name = "game" + DateTime.Now,
                BeginPlay = DateTime.Now,
                Board = newBoard,
            };
        }
        private void RandomPiece()
        {
        }

    }
}

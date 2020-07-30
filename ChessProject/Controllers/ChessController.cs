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
        private Board newBoard = new BoardsController().Create();
        private Chess newChess = new Chess();

        public IActionResult Index()
        {
            Create();
            return View();
        }

        public ActionResult NewGame() {
            newChess.Board = new BoardsController().Inicializate();
            return View(); //FALTA
        }
        private void Create()
        {
            newChess.Name = "game" + DateTime.Now;
            newChess.BeginPlay = DateTime.Now;
            newChess.Board = newBoard;
        }


    }
}

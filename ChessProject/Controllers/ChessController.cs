﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessProject.Models;
using ChessProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.Logging;

namespace ChessProject.Controllers
{
    public class ChessController : Controller
    {
        private Board newBoard = new BoardsController().Create();
        Chess newChess = new Chess();

        public IActionResult Index()
        {
            newChess = Create();
            ViewBag.Pieces = newChess.Board.Pieces;

            return View();
        }

        public IActionResult NewGame() {

            newChess = Create();
            newChess.Board = new BoardsController().Inicializate(newBoard);
            ViewBag.Pieces = newChess.Board.Pieces;
            TempData["mensaje"] = "redirect";

            return RedirectToAction("Index"); 
        }

        public IActionResult SaveMove() {
            TempData["mensaje"] = "redirect";
            return RedirectToAction("Index");
        }

        private Chess Create()
        {
            newChess.Name = "game" + DateTime.Now;
            newChess.BeginPlay = DateTime.Now;
            newChess.Board = newBoard;

            return newChess;
        }


    }
}

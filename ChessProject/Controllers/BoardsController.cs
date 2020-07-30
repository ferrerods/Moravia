﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChessProject.Models;

namespace ChessProject.Controllers
{
    public class BoardsController : Controller
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

        List<Square> squareList = new List<Square>();
        List<Piece> pieceList = new List<Piece>();

        public IActionResult Index()
        {
            return View();
        }

        public Board Initialize()
        {
            try {

                Board newBoard = new Board();

                #region Square 
                for (int i = 1; i < nroColumn + 1; i++)
                {
                    //si fila par comienza con light o i = 1
                    if ((i / 2) == 0) { colorSquare = colorSquareL; }
                    else if ((i == 1) || (i / 2) != 0) { colorSquare = colorSquareD; }

                    foreach (string item in Row)
                    {
                        Square squareiitem = new Square
                        {
                            Name = "square" + i + item,
                            PositionY = i.ToString(),
                            PositionX = item,
                            Color = colorSquare,
                            Empty = true
                        };

                        squareList.Add(squareiitem);

                        if (colorSquare == colorSquareD) { colorSquare = colorSquareL; }
                    }
                }
                #endregion

                #region Piece

                #region Pawn    
                for (int p = 1; p < (nroColumn * 2); p++)
                {

                    if (nroColumn <= p)
                    {
                        //create piece Pawn Black
                        PiecePawn pawnpcolorB = new PiecePawn
                        {
                            Name = "pawn" + p + colorB,
                            Color = colorB,
                            Dead = false
                        };

                        pieceList.Add(pawnpcolorB);
                    }
                    else
                    {
                        var aux = (p - nroColumn);
                        //create piece Pawn White
                        PiecePawn pawnauxcolorW = new PiecePawn
                        {
                            Name = "pawn" + aux + colorW,
                            Color = colorW,
                            Dead = false
                        };

                        pieceList.Add(pawnauxcolorW);
                    }
                }
                #endregion

                #region Tower
                for (int t = 1; t < (nroColumn / 2); t++)
                {
                    if ((nroColumn / 2) <= t)
                    {
                        //create piece Tower Black
                        PieceTower towertcolorB = new PieceTower
                        {
                            Name = "tower" + t + colorB,
                            Color = colorB,
                            Dead = false
                        };

                        pieceList.Add(towertcolorB);
                    }
                    else
                    {
                        var taux = (t - nroColumn);

                        //create piece Tower White
                        PieceTower towertauxcolorW = new PieceTower
                        {
                            Name = "tower" + taux + colorW,
                            Color = colorW,
                            Dead = false
                        };

                        pieceList.Add(towertauxcolorW);
                    }
                }
                #endregion

                #region Bishop
                for (int t = 1; t < (nroColumn / 2); t++)
                {
                    if ((nroColumn / 2) <= t)
                    {
                        //create piece Bishop Black
                        PieceBishop bishoptcolorB = new PieceBishop
                        {
                            Name = "bishop" + t + colorB,
                            Color = colorB,
                            Dead = false
                        };

                        pieceList.Add(bishoptcolorB);
                    }
                    else
                    {
                        var taux = (t - nroColumn);

                        //create piece Bishop White
                        PieceBishop bishoptauxcolorB = new PieceBishop
                        {
                            Name = "bishop" + taux + colorW,
                            Color = colorW,
                            Dead = false
                        };

                        pieceList.Add(bishoptauxcolorB);
                    }
                }
                #endregion Bishop

                #region Horse
                for (int t = 1; t < (nroColumn / 2); t++)
                {
                    if ((nroColumn / 2) <= t)
                    {
                        //create piece Horse Black
                        PieceHorse horsetcolorB = new PieceHorse
                        {
                            Name = "horse" + t + colorB,
                            Color = colorB,
                            Dead = false
                        };

                        pieceList.Add(horsetcolorB);
                    }
                    else
                    {
                        var taux = (t - nroColumn);

                        //create piece Horse White
                        PieceHorse horsetauxcolorB = new PieceHorse
                        {
                            Name = "horse" + taux + colorW,
                            Color = colorW,
                            Dead = false
                        };

                        pieceList.Add(horsetauxcolorB);
                    }
                }
                #endregion

                #region Queen
                //create piece queen Black
                PieceQueen queencolorB = new PieceQueen
                {
                    Name = "queen" + colorB,
                    Color = colorB,
                    Dead = false
                };

                pieceList.Add(queencolorB);

                //create piece queen White
                PieceKing queencolorW = new PieceKing
                {
                    Name = "queen" + colorW,
                    Color = colorW,
                    Dead = false
                };

                pieceList.Add(queencolorW);
                #endregion

                #region King
                //create piece queen Black
                PieceKing kingcolorB = new PieceKing
                {
                    Name = "king" + colorB,
                    Color = colorB,
                    Dead = false
                };

                pieceList.Add(kingcolorB);

                //create piece queen White
                PieceKing kingcolorW = new PieceKing
                {
                    Name = "king" + colorW,
                    Color = colorW,
                    Dead = false
                };

                pieceList.Add(kingcolorW);
                #endregion

                #endregion

                newBoard.Squares = squareList;
                newBoard.Pieces = pieceList;

                return newBoard;
            }
            catch (Exception ex) { return null; }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChessProject.Models;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace ChessProject.Controllers
{
    public class BoardsController : Controller
    {
        Board newBoard = new Board();

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

        public Board Create()
        {
            try {

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
                for (int p = 1; p < ((nroColumn * 2)+1); p++)
                {

                    if (nroColumn >= p)
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
                //create piece Tower Black
                PieceTower tower1colorB = new PieceTower
                {
                    Name = "tower1" + colorB,
                    Color = colorB,
                    Dead = false
                };

                PieceTower tower2colorB = new PieceTower
                {
                    Name = "tower2" + colorB,
                    Color = colorB,
                    Dead = false
                };

                pieceList.Add(tower1colorB);
                pieceList.Add(tower2colorB);
                    
                //create piece Tower White
                PieceTower tower1colorW = new PieceTower
                {
                    Name = "tower1" + colorW,
                    Color = colorW,
                    Dead = false
                };

                PieceTower tower2colorW = new PieceTower
                {
                    Name = "tower2" + colorW,
                    Color = colorW,
                    Dead = false
                };

                pieceList.Add(tower1colorW);
                pieceList.Add(tower2colorW);
                #endregion

                #region Bishop
                //create piece Bishop Black
                PieceBishop bishop1colorB = new PieceBishop
                {
                    Name = "bishop1" + colorB,
                    Color = colorB,
                    Dead = false
                };

                PieceBishop bishop2colorB = new PieceBishop
                {
                    Name = "bishop2" + colorB,
                    Color = colorB,
                    Dead = false
                };

                pieceList.Add(bishop1colorB);
                pieceList.Add(bishop2colorB);

                //create piece Bishop White
                PieceBishop bishop1colorW = new PieceBishop
                {
                    Name = "bishop1" + colorW,
                    Color = colorW,
                    Dead = false
                };

                PieceBishop bishop2colorW = new PieceBishop
                {
                    Name = "bishop2" + colorW,
                    Color = colorW,
                    Dead = false
                };

                pieceList.Add(bishop1colorW);
                pieceList.Add(bishop2colorW);

                #endregion Bishop

                #region Horse
                //create piece Horse Black
                PieceHorse horse1colorB = new PieceHorse
                {
                    Name = "horse1" + colorB,
                    Color = colorB,
                    Dead = false
                };

                PieceHorse horse2colorB = new PieceHorse
                {
                    Name = "horse2" + colorB,
                    Color = colorB,
                    Dead = false
                };

                pieceList.Add(horse1colorB);
                pieceList.Add(horse2colorB);
                   
                //create piece Horse White
                PieceHorse horse1colorW = new PieceHorse
                {
                    Name = "horse1" + colorW,
                    Color = colorW,
                    Dead = false
                };

                PieceHorse horse2colorW = new PieceHorse
                {
                    Name = "horse2" + colorW,
                    Color = colorW,
                    Dead = false
                };

                pieceList.Add(horse1colorW);
                pieceList.Add(horse2colorW);

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

                RandomPieces();

                return newBoard;
            }
            catch (Exception ex) { return null; }

        }

        public void RandomPieces() 
        { 

        }

        public Board Inicializate()
        {
            try { 
                CleanBoard();

                var fila7 = "7";
                var fila8 = "8";
                var fila1 = "1";
                var fila2 = "2";

                #region black
                //pawn
                foreach (string r in Row)
                {
                    foreach (Piece piece in (newBoard.Pieces.Where(p => p.Name.Contains("pawn") && p.Color.Equals(colorB))))
                    {
                        piece.PositionX = r;
                        piece.PositionY = fila7;

                        (newBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila7)).Piece = piece;
                        (newBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila7)).Empty = false;
                    }
                }
                //queen
                newBoard.Pieces.First(p => p.Name.Contains("queenBlack")).PositionX = "e";
                newBoard.Pieces.First(p => p.Name.Contains("queenBlack")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("e8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("queenBlack"));
                (newBoard.Squares.First(s => s.Name.Contains("e8"))).Empty = false;

                //king
                newBoard.Pieces.First(p => p.Name.Contains("kingBlack")).PositionX = "d";
                newBoard.Pieces.First(p => p.Name.Contains("kingBlack")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("d8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("kingBlack"));
                (newBoard.Squares.First(s => s.Name.Contains("d8"))).Empty = false;

                //tower
                newBoard.Pieces.First(p => p.Name.Contains("tower1Black")).PositionX = "a";
                newBoard.Pieces.First(p => p.Name.Contains("tower1Black")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("a8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("tower1Black"));
                (newBoard.Squares.First(s => s.Name.Contains("a8"))).Empty = false;

                newBoard.Pieces.First(p => p.Name.Contains("tower2Black")).PositionX = "h";
                newBoard.Pieces.First(p => p.Name.Contains("tower2Black")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("h8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("tower2Black"));
                (newBoard.Squares.First(s => s.Name.Contains("h8"))).Empty = false;

                //horse
                newBoard.Pieces.First(p => p.Name.Contains("horse1Black")).PositionX = "b";
                newBoard.Pieces.First(p => p.Name.Contains("horse1Black")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("b8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("horse1Black"));
                (newBoard.Squares.First(s => s.Name.Contains("b8"))).Empty = false;

                newBoard.Pieces.First(p => p.Name.Contains("horse2Black")).PositionX = "g";
                newBoard.Pieces.First(p => p.Name.Contains("horse2Black")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("g8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("horse2Black"));
                (newBoard.Squares.First(s => s.Name.Contains("g8"))).Empty = false;

                //bishop
                newBoard.Pieces.First(p => p.Name.Contains("bishop1Black")).PositionX = "c";
                newBoard.Pieces.First(p => p.Name.Contains("bishop1Black")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("c8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("bishop1Black"));
                (newBoard.Squares.First(s => s.Name.Contains("c8"))).Empty = false;

                newBoard.Pieces.First(p => p.Name.Contains("bishop2Black")).PositionX = "f";
                newBoard.Pieces.First(p => p.Name.Contains("bishop2Black")).PositionY = fila8;
                (newBoard.Squares.First(s => s.Name.Contains("f8"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("bishop2Black"));
                (newBoard.Squares.First(s => s.Name.Contains("f8"))).Empty = false;
                #endregion

                #region white
                //pawn
                foreach (string r in Row)
                {
                    foreach (Piece piece in (newBoard.Pieces.Where(p => p.Name.Contains("pawn") && p.Color.Equals(colorW))))
                    {
                        piece.PositionX = r;
                        piece.PositionY = fila2;

                        (newBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila2)).Piece = piece;
                        (newBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila2)).Empty = false;
                    }
                }

                //queen
                newBoard.Pieces.First(p => p.Name.Contains("queenWhite")).PositionX = "e";
                newBoard.Pieces.First(p => p.Name.Contains("queenWhite")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("e1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("queenWhite"));
                (newBoard.Squares.First(s => s.Name.Contains("e1"))).Empty = false;

                //king
                newBoard.Pieces.First(p => p.Name.Contains("kingWhite")).PositionX = "d";
                newBoard.Pieces.First(p => p.Name.Contains("kingWhite")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("d1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("kingWhite"));
                (newBoard.Squares.First(s => s.Name.Contains("d1"))).Empty = false;

                //tower
                newBoard.Pieces.First(p => p.Name.Contains("tower1White")).PositionX = "a";
                newBoard.Pieces.First(p => p.Name.Contains("tower1White")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("a1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("tower1White"));
                (newBoard.Squares.First(s => s.Name.Contains("a1"))).Empty = false;

                newBoard.Pieces.First(p => p.Name.Contains("tower2White")).PositionX = "h";
                newBoard.Pieces.First(p => p.Name.Contains("tower2White")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("h1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("tower2White"));
                (newBoard.Squares.First(s => s.Name.Contains("h1"))).Empty = false;

                //horse
                newBoard.Pieces.First(p => p.Name.Contains("horse1White")).PositionX = "b";
                newBoard.Pieces.First(p => p.Name.Contains("horse1White")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("b1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("horse1Black"));
                (newBoard.Squares.First(s => s.Name.Contains("b1"))).Empty = false;

                newBoard.Pieces.First(p => p.Name.Contains("horse2White")).PositionX = "g";
                newBoard.Pieces.First(p => p.Name.Contains("horse2White")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("g1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("horse2White"));
                (newBoard.Squares.First(s => s.Name.Contains("g1"))).Empty = false;

                //bishop
                newBoard.Pieces.First(p => p.Name.Contains("bishop1White")).PositionX = "c";
                newBoard.Pieces.First(p => p.Name.Contains("bishop1White")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("c1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("bishop1White"));
                (newBoard.Squares.First(s => s.Name.Contains("c1"))).Empty = false;

                newBoard.Pieces.First(p => p.Name.Contains("bishop2White")).PositionX = "f";
                newBoard.Pieces.First(p => p.Name.Contains("bishop2White")).PositionY = fila1;
                (newBoard.Squares.First(s => s.Name.Contains("f1"))).Piece = newBoard.Pieces.First(p => p.Name.Contains("bishop2White"));
                (newBoard.Squares.First(s => s.Name.Contains("f1"))).Empty = false;

                #endregion

                return newBoard;
            }
            catch (Exception ex) { return null; }
        }

        private void CleanBoard()
        {
            foreach (Square square in newBoard.Squares) {
                if (square.Empty == false)
                {
                    square.Empty = true;
                    square.Piece = null;
                }
            }

            foreach (Piece piece in newBoard.Pieces) { 
                if(piece.Dead == true)
                {
                    piece.Dead = false;
                    piece.PositionX = string.Empty;
                    piece.PositionY = string.Empty;
                }
            }
        }
    }
}

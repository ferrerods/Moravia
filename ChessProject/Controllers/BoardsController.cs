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
        private string[] Row = { "a", "b", "c", "d", "e", "f", "g", "h" };
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

                int countNroSquare = 0;

                #region Square 
                for (int i = 1; i < nroColumn + 1; i++)
                {                    
                    if (countNroSquare == 0 || countNroSquare == 16
                        || countNroSquare == 32 || countNroSquare == 48 || countNroSquare == 64)
                    { colorSquare = colorSquareD; }
                    if (countNroSquare == 8 || countNroSquare == 24
                        || countNroSquare == 40 || countNroSquare == 56)
                    { colorSquare = colorSquareL; }

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
                        else { colorSquare = colorSquareD; }

                        countNroSquare++;
                    }
                }
                #endregion

                #region Piece

                #region Pawn    
                for (int p = 1; p < ((nroColumn * 2) + 1); p++)
                {

                    if (nroColumn >= p)
                    {
                        //create piece Pawn Black
                        PiecePawn pawnpcolorB = new PiecePawn
                        {
                            Name = "pawn" + p + colorB,
                            Color = colorB,
                            Dead = false,
                            Img = "♟",
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
                            Dead = false,
                            Img = "♙",
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
                    Dead = false,
                    Img = "♜",
                };

                PieceTower tower2colorB = new PieceTower
                {
                    Name = "tower2" + colorB,
                    Color = colorB,
                    Dead = false,
                    Img = "♜",
                };

                pieceList.Add(tower1colorB);
                pieceList.Add(tower2colorB);

                //create piece Tower White
                PieceTower tower1colorW = new PieceTower
                {
                    Name = "tower1" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♖",
                };

                PieceTower tower2colorW = new PieceTower
                {
                    Name = "tower2" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♖",
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
                    Dead = false,
                    Img = "♝",
                };

                PieceBishop bishop2colorB = new PieceBishop
                {
                    Name = "bishop2" + colorB,
                    Color = colorB,
                    Dead = false,
                    Img = "♝",
                };

                pieceList.Add(bishop1colorB);
                pieceList.Add(bishop2colorB);

                //create piece Bishop White
                PieceBishop bishop1colorW = new PieceBishop
                {
                    Name = "bishop1" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♗",
                };

                PieceBishop bishop2colorW = new PieceBishop
                {
                    Name = "bishop2" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♗",
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
                    Dead = false,
                    Img = "♞",
                };

                PieceHorse horse2colorB = new PieceHorse
                {
                    Name = "horse2" + colorB,
                    Color = colorB,
                    Dead = false,
                    Img = "♞",
                };

                pieceList.Add(horse1colorB);
                pieceList.Add(horse2colorB);

                //create piece Horse White
                PieceHorse horse1colorW = new PieceHorse
                {
                    Name = "horse1" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♘",
                };

                PieceHorse horse2colorW = new PieceHorse
                {
                    Name = "horse2" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♘",
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
                    Dead = false,
                    Img = "♛",
                };

                pieceList.Add(queencolorB);

                //create piece queen White
                PieceKing queencolorW = new PieceKing
                {
                    Name = "queen" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♕",
                };

                pieceList.Add(queencolorW);
                #endregion

                #region King
                //create piece king Black
                PieceKing kingcolorB = new PieceKing
                {
                    Name = "king" + colorB,
                    Color = colorB,
                    Dead = false,
                    Img = "♚",
                };

                pieceList.Add(kingcolorB);

                //create piece king White
                PieceKing kingcolorW = new PieceKing
                {
                    Name = "king" + colorW,
                    Color = colorW,
                    Dead = false,
                    Img = "♔",
                };

                pieceList.Add(kingcolorW);
                #endregion

                #endregion

                newBoard.Squares = squareList;
                newBoard.Pieces = pieceList;

                newBoard = RandomPieces(newBoard);

                return newBoard;
            }
            catch (Exception ex) { return null; }

        }

        public Board RandomPieces(Board newBoard)
        {
            try
            {
                List<int> listNro = RandomList();
                var nro = 0;

                foreach (Piece item in newBoard.Pieces)
                {
                    if (!item.Name.Contains("bishop")) {

                        newBoard.Squares[listNro[nro]].Piece = item;
                        newBoard.Squares[listNro[nro]].ImgPiece = item.Img;

                        newBoard.Pieces.First(f => f.Name == item.Name).PositionX = newBoard.Squares[listNro[nro]].PositionX;
                        newBoard.Pieces.First(f => f.Name == item.Name).PositionY = newBoard.Squares[listNro[nro]].PositionY;
                    }

                    nro++;
                }

                int countNro = 0;

                for (int p = nro; p <= listNro.Count + 1; p++)
                {
                    if (p == nro) {
                        newBoard.Squares[listNro[p]].Piece = newBoard.Pieces[20];
                        newBoard.Squares[listNro[p]].ImgPiece = newBoard.Pieces[20].Img;

                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[20].Name).PositionX = newBoard.Squares[listNro[p]].PositionX;
                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[20].Name).PositionY = newBoard.Squares[listNro[p]].PositionY;
                    }

                    if (newBoard.Squares[listNro[nro]].Color != newBoard.Squares[listNro[p]].Color) {
                        newBoard.Squares[listNro[p]].Piece = newBoard.Pieces[21];
                        newBoard.Squares[listNro[p]].ImgPiece = newBoard.Pieces[21].Img;

                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[21].Name).PositionX = newBoard.Squares[listNro[p]].PositionX;
                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[21].Name).PositionY = newBoard.Squares[listNro[p]].PositionY;

                        countNro = p+1;

                        break;
                    }
                }

                for (int t = countNro; t <= listNro.Count + 1; t++)
                {
                    if (t == countNro)
                    {
                        newBoard.Squares[listNro[t]].Piece = newBoard.Pieces[22];
                        newBoard.Squares[listNro[t]].ImgPiece = newBoard.Pieces[22].Img;

                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[22].Name).PositionX = newBoard.Squares[listNro[t]].PositionX;
                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[22].Name).PositionY = newBoard.Squares[listNro[t]].PositionY;
                    }

                    if (newBoard.Squares[listNro[countNro]].Color != newBoard.Squares[listNro[t]].Color)
                    {
                        newBoard.Squares[listNro[t]].Piece = newBoard.Pieces[23];
                        newBoard.Squares[listNro[t]].ImgPiece = newBoard.Pieces[23].Img;

                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[23].Name).PositionX = newBoard.Squares[listNro[t]].PositionX;
                        newBoard.Pieces.First(f => f.Name == newBoard.Pieces[23].Name).PositionY = newBoard.Squares[listNro[t]].PositionY;

                        break;
                    }
                }

                return newBoard;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<int> RandomList()
        {
            List<int> values = new List<int>();

            for (int i = 0; i < 64; i++) {
                values.Add(i);
            }

            var n = values.Count;
            var rnd = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                var j = rnd.Next(0, i);
                var temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }

            return values;
        }

        public Board Inicializate(Board activeBoard)
        {
            try {

                if (activeBoard == null){ activeBoard = Create(); }
                else { CleanBoard(activeBoard); }

                var fila7 = "7";
                var fila8 = "8";
                var fila1 = "1";
                var fila2 = "2";

                #region black
                //pawn
                foreach (string r in Row)
                {
                    foreach (Piece piece in (activeBoard.Pieces.Where(p => p.Name.Contains("pawn") && p.Color.Equals(colorB))))
                    {
                        piece.PositionX = r;
                        piece.PositionY = fila7;

                        (activeBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila7)).Piece = piece;
                        (activeBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila7)).Empty = false;
                    }
                }
                //queen
                activeBoard.Pieces.First(p => p.Name.Contains("queenBlack")).PositionX = "d";
                activeBoard.Pieces.First(p => p.Name.Contains("queenBlack")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8d"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("queenBlack"));
                (activeBoard.Squares.First(s => s.Name.Contains("8d"))).Empty = false;

                //king
                activeBoard.Pieces.First(p => p.Name.Contains("kingBlack")).PositionX = "e";
                activeBoard.Pieces.First(p => p.Name.Contains("kingBlack")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8e"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("kingBlack"));
                (activeBoard.Squares.First(s => s.Name.Contains("8e"))).Empty = false;

                //tower
                activeBoard.Pieces.First(p => p.Name.Contains("tower1Black")).PositionX = "a";
                activeBoard.Pieces.First(p => p.Name.Contains("tower1Black")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8a"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("tower1Black"));
                (activeBoard.Squares.First(s => s.Name.Contains("8a"))).Empty = false;

                activeBoard.Pieces.First(p => p.Name.Contains("tower2Black")).PositionX = "h";
                activeBoard.Pieces.First(p => p.Name.Contains("tower2Black")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8h"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("tower2Black"));
                (activeBoard.Squares.First(s => s.Name.Contains("8h"))).Empty = false;

                //horse
                activeBoard.Pieces.First(p => p.Name.Contains("horse1Black")).PositionX = "b";
                activeBoard.Pieces.First(p => p.Name.Contains("horse1Black")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8b"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("horse1Black"));
                (activeBoard.Squares.First(s => s.Name.Contains("8b"))).Empty = false;

                activeBoard.Pieces.First(p => p.Name.Contains("horse2Black")).PositionX = "g";
                activeBoard.Pieces.First(p => p.Name.Contains("horse2Black")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8g"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("horse2Black"));
                (activeBoard.Squares.First(s => s.Name.Contains("8g"))).Empty = false;

                //bishop
                activeBoard.Pieces.First(p => p.Name.Contains("bishop1Black")).PositionX = "c";
                activeBoard.Pieces.First(p => p.Name.Contains("bishop1Black")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8c"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("bishop1Black"));
                (activeBoard.Squares.First(s => s.Name.Contains("8c"))).Empty = false;

                activeBoard.Pieces.First(p => p.Name.Contains("bishop2Black")).PositionX = "f";
                activeBoard.Pieces.First(p => p.Name.Contains("bishop2Black")).PositionY = fila8;
                (activeBoard.Squares.First(s => s.Name.Contains("8f"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("bishop2Black"));
                (activeBoard.Squares.First(s => s.Name.Contains("8f"))).Empty = false;
                #endregion

                #region white
                //pawn
                foreach (string r in Row)
                {
                    foreach (Piece piece in (activeBoard.Pieces.Where(p => p.Name.Contains("pawn") && p.Color.Equals(colorW))))
                    {
                        piece.PositionX = r;
                        piece.PositionY = fila2;

                        (activeBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila2)).Piece = piece;
                        (activeBoard.Squares.First(s => s.PositionX == r && s.PositionY == fila2)).Empty = false;
                    }
                }

                //queen
                activeBoard.Pieces.First(p => p.Name.Contains("queenWhite")).PositionX = "d";
                activeBoard.Pieces.First(p => p.Name.Contains("queenWhite")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1d"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("queenWhite"));
                (activeBoard.Squares.First(s => s.Name.Contains("1d"))).Empty = false;

                //king
                activeBoard.Pieces.First(p => p.Name.Contains("kingWhite")).PositionX = "e";
                activeBoard.Pieces.First(p => p.Name.Contains("kingWhite")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1e"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("kingWhite"));
                (activeBoard.Squares.First(s => s.Name.Contains("1e"))).Empty = false;

                //tower
                activeBoard.Pieces.First(p => p.Name.Contains("tower1White")).PositionX = "a";
                activeBoard.Pieces.First(p => p.Name.Contains("tower1White")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1a"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("tower1White"));
                (activeBoard.Squares.First(s => s.Name.Contains("1a"))).Empty = false;

                activeBoard.Pieces.First(p => p.Name.Contains("tower2White")).PositionX = "h";
                activeBoard.Pieces.First(p => p.Name.Contains("tower2White")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1h"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("tower2White"));
                (activeBoard.Squares.First(s => s.Name.Contains("1h"))).Empty = false;

                //horse
                activeBoard.Pieces.First(p => p.Name.Contains("horse1White")).PositionX = "b";
                activeBoard.Pieces.First(p => p.Name.Contains("horse1White")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1b"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("horse1Black"));
                (activeBoard.Squares.First(s => s.Name.Contains("1b"))).Empty = false;

                activeBoard.Pieces.First(p => p.Name.Contains("horse2White")).PositionX = "g";
                activeBoard.Pieces.First(p => p.Name.Contains("horse2White")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1g"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("horse2White"));
                (activeBoard.Squares.First(s => s.Name.Contains("1g"))).Empty = false;

                //bishop
                activeBoard.Pieces.First(p => p.Name.Contains("bishop1White")).PositionX = "c";
                activeBoard.Pieces.First(p => p.Name.Contains("bishop1White")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1c"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("bishop1White"));
                (activeBoard.Squares.First(s => s.Name.Contains("1c"))).Empty = false;

                activeBoard.Pieces.First(p => p.Name.Contains("bishop2White")).PositionX = "f";
                activeBoard.Pieces.First(p => p.Name.Contains("bishop2White")).PositionY = fila1;
                (activeBoard.Squares.First(s => s.Name.Contains("1f"))).Piece = activeBoard.Pieces.First(p => p.Name.Contains("bishop2White"));
                (activeBoard.Squares.First(s => s.Name.Contains("1f"))).Empty = false;

                #endregion

                return activeBoard;
            }
            catch (Exception ex) { return null; }
        }

        private void CleanBoard(Board activeBoard)
        {
            if(activeBoard != null && (activeBoard.Squares != null || activeBoard.Squares.Count != 0))
            {
                foreach (Square square in activeBoard.Squares)
                {
                    if (square.Empty == false)
                    {
                        square.Empty = true;
                        square.Piece = null;
                    }
                }
            }

            if (activeBoard != null && (activeBoard.Pieces != null || activeBoard.Pieces.Count != 0))
            {
                foreach (Piece piece in activeBoard.Pieces)
                {
                    if (piece.Dead == true)
                    {
                        piece.Dead = false;
                        piece.PositionX = string.Empty;
                        piece.PositionY = string.Empty;
                    }
                }
            }
        }
    }
}

using ChessGame.Entities._Board;
using ChessGame.Entities.ChessGame;
using ChessGame.Entities.Enums;
using ChessGame.Entities.Exceptions;
using ChessGame.Views;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);
                board.PutPiece(new Rook(Color.Black, board), new Position(0, 0));
                board.PutPiece(new Rook(Color.Black, board), new Position(1, 3));
                board.PutPiece(new King(Color.Black, board), new Position(2, 4));

                ViewBoard.PrintBoard(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
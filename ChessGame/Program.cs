using ChessGame.Entities._Board;
using ChessGame.Entities.Chess;
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
                ChessMatch match = new ChessMatch();

                while (!match.Finished)
                {
                    Console.Clear();
                    ViewBoard.PrintBoard(match.Board);

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = ViewBoard.ReadChessPosition().ToPosition();

                    Console.Write("Destination: ");
                    Position destination = ViewBoard.ReadChessPosition().ToPosition();

                    match.MakeMove(origin, destination);
                }

                ViewBoard.PrintBoard(match.Board);


            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
using ChessGame.Entities._Board;
using ChessGame.Entities.Enums;

namespace ChessGame.Entities.Chess
{
    class ChessMatch
    {
        public Board Board { get; private set; }
        public int Turn { get; private set; }
        private Color PlayerTurn;
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Turn = 1;
            PlayerTurn = Color.White;
            Finished = false;
            AddPieces();
        }

        public void MakeMove(Position origin, Position destination)
        {
            Piece p = Board.RemovePiece(origin);
            p.IncreaseMovements();
            Piece CapturedPiece = Board.RemovePiece(destination);
            Board.AddPiece(p, destination);
        }

        private void AddPieces()
        {
            Board.AddPiece(new Rook(Color.Black, Board), new ChessPosition('c', 1).ToPosition());
        }

    }
}

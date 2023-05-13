using ChessGame.Entities._Board;
using ChessGame.Entities.Enums;

namespace ChessGame.Entities.ChessGame
{
    class Rook : Piece
    {
        public Rook() { }
        public Rook(Color color, Board board) : base(color, board) { }

        public override string ToString()
        {
            return "R";
        }
    }
}

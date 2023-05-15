using ChessGame.Entities._Board;
using ChessGame.Entities.Enums;

namespace ChessGame.Entities.Chess
{
    class King : Piece
    {
        public King() { }
        public King(Color color, Board board) : base(color, board) { }

        public override string ToString()
        {
            return "K";
        }
    }

}

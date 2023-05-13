using ChessGame.Entities.Enums;

namespace ChessGame.Entities._Board
{
    class Piece
    {
        public Color Color { get; protected set; }
        public int Movements { get; protected set; }
        public Board Board { get; protected set; }
        public Position Position { get; set; }

        public Piece() { }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Movements = 0;
            Board = board;
        }

    }
}

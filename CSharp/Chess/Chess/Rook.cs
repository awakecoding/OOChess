using System;

namespace Chess
{
	public class Rook : ChessPiece
	{
		public Rook(ChessColor color, Position position) : base(color, position)
		{
			character = (color == ChessColor.Black) ? '\u265C' : '\u2656';
		}
		
		public override string GetName()
		{
			return "Rook";
		}
		
		public override int GetMaxCount()
		{
			return 2;
		}
	}
}


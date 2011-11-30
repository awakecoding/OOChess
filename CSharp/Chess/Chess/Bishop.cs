using System;

namespace Chess
{
	public class Bishop : ChessPiece
	{
		public Bishop(ChessColor color, Position position) : base(color, position)
		{
			character = (color == ChessColor.Black) ? '\u265D' : '\u2657';
		}
		
		public override string GetName()
		{
			return "Bishop";
		}
		
		public override int GetMaxCount()
		{
			return 2;
		}
	}
}


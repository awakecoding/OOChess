using System;

namespace Chess
{
	public class King : ChessPiece
	{
		public King(ChessColor color, Position position) : base(color, position)
		{
			character = (color == ChessColor.Black) ? '\u265A' : '\u2654';
		}
		
		public override string GetName()
		{
			return "King";
		}
		
		public override int GetMaxCount()
		{
			return 1;
		}
	}
}


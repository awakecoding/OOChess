using System;

namespace Chess
{
	public class Knight : ChessPiece
	{
		public Knight(ChessColor color, Position position) : base(color, position)
		{
			character = (color == ChessColor.Black) ? '\u265E' : '\u2658';
		}
		
		public override string GetName()
		{
			return "Knight";
		}
		
		public override int GetMaxCount()
		{
			return 2;
		}
	}
}


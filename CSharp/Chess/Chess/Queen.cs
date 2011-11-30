using System;

namespace Chess
{
	public class Queen : ChessPiece
	{
		public Queen(ChessColor color, Position position) : base(color, position)
		{
			character = (color == ChessColor.Black) ? '\u265B' : '\u2655';
		}
		
		public override string GetName()
		{
			return "Queen";
		}
		
		public override int GetMaxCount()
		{
			return 1;
		}
	}
}


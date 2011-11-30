using System;

namespace Chess
{
	public class Queen : Piece
	{
		public Queen(Color color, Position position) : base(color, position)
		{
			character = (color == Color.Black) ? '\u265B' : '\u2655';
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


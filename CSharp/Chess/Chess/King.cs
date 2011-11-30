using System;

namespace Chess
{
	public class King : Piece
	{
		public King(Color color, Position position) : base(color, position)
		{
			character = (color == Color.Black) ? '\u265A' : '\u2654';
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


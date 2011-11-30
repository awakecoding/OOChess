using System;

namespace Chess
{
	public class Knight : Piece
	{
		public Knight(Color color, Position position) : base(color, position)
		{
			character = (color == Color.Black) ? '\u265E' : '\u2658';
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


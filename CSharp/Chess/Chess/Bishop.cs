using System;

namespace Chess
{
	public class Bishop : Piece
	{
		public Bishop(Color color, Position position) : base(color, position)
		{
			character = (color == Color.Black) ? '\u265D' : '\u2657';
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


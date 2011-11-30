using System;

namespace Chess
{
	public class Rook : Piece
	{
		public Rook(Color color, Position position) : base(color, position)
		{
			character = (color == Color.Black) ? '\u265C' : '\u2656';
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


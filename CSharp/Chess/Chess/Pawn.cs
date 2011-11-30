using System;

namespace Chess
{
	public class Pawn : Piece
	{
		public Pawn(Color color, Position position) : base(color, position)
		{
			character = (color == Color.Black) ? '\u265F' : '\u2659';
		}
		
		public override string GetName()
		{
			return "Pawn";
		}
		
		public override int GetMaxCount()
		{
			return 8;
		}
	}
}


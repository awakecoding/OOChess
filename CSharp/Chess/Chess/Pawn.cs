using System;

namespace Chess
{
	public class Pawn : ChessPiece
	{
		public Pawn(ChessColor color, Position position) : base(color, position)
		{
			character = (color == ChessColor.Black) ? '\u265F' : '\u2659';
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


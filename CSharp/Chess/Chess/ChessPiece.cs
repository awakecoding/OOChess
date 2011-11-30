using System;

namespace Chess
{
	public abstract class ChessPiece
	{
		protected char character;
		private ChessColor color;
		private Position position;
		
		public ChessPiece(ChessColor color, Position position)
		{
			this.color = color;
			this.position = position;
		}
		
		public abstract string GetName();
		public abstract int GetMaxCount();
		
		public override string ToString()
		{
			return color + " " + GetName() + " (" + position + ")";
		}
	}
}


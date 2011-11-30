using System;

namespace Chess
{
	public abstract class Piece
	{
		protected char character;
		private Color color;
		private Position position;
		
		public Piece(Color color, Position position)
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


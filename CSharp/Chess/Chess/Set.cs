using System;

namespace Chess
{
	public enum Color
	{
		Black,
		White
	}
	
	public class Set
	{	
		private King king;
		private Queen queen;
		private Rook rookA;
		private Rook rookB;
		private Knight knightA;
		private Knight knightB;
		private Bishop bishopA;
		private Bishop bishopB;
		private Pawn pawnA;
		private Pawn pawnB;
		private Pawn pawnC;
		private Pawn pawnD;
		private Pawn pawnE;
		private Pawn pawnF;
		private Pawn pawnG;
		private Pawn pawnH;
		
		private Color color;
		public Piece[] pieces;

		public Set(Color color)
		{
			int rank;
			this.color = color;
			pieces = new Piece[16];
		
			rank = (color == Color.Black) ? 8 : 1;
			pieces[0] = rookA = new Rook(color, new Position(rank, 'a'));
			pieces[1] = knightA = new Knight(color, new Position(rank, 'b'));
			pieces[2] = bishopA = new Bishop(color, new Position(rank, 'c'));
			pieces[3] = king = new King(color, new Position(rank, 'd'));
			pieces[4] = queen = new Queen(color, new Position(rank, 'e'));
			pieces[5] = bishopB = new Bishop(color, new Position(rank, 'f'));
			pieces[6] = knightB = new Knight(color, new Position(rank, 'g'));
			pieces[7] = rookB = new Rook(color, new Position(rank, 'h'));
			
			rank = (color == Color.Black) ? 7 : 2;
			pieces[8] = pawnA = new Pawn(color, new Position(rank, 'a'));
			pieces[9] = pawnB = new Pawn(color, new Position(rank, 'b'));
			pieces[10] = pawnC = new Pawn(color, new Position(rank, 'c'));
			pieces[11] = pawnD = new Pawn(color, new Position(rank, 'd'));
			pieces[12] = pawnE = new Pawn(color, new Position(rank, 'e'));
			pieces[13] = pawnF = new Pawn(color, new Position(rank, 'f'));
			pieces[14] = pawnG = new Pawn(color, new Position(rank, 'g'));
			pieces[15] = pawnH = new Pawn(color, new Position(rank, 'h'));
		}
	}
}


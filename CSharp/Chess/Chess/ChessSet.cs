using System;

namespace Chess
{
	public enum ChessColor
	{
		Black,
		White
	}
	
	public class ChessSet
	{	
		private King king;
		private Queen queen;
		private Rook rookA;
		private Rook rookH;
		private Knight knightB;
		private Knight knightG;
		private Bishop bishopC;
		private Bishop bishopF;
		private Pawn pawnA;
		private Pawn pawnB;
		private Pawn pawnC;
		private Pawn pawnD;
		private Pawn pawnE;
		private Pawn pawnF;
		private Pawn pawnG;
		private Pawn pawnH;
		
		private ChessColor color;
		public ChessPiece[] pieces;

		public ChessSet(ChessColor color)
		{
			int rank;
			this.color = color;
			pieces = new ChessPiece[16];
		
			rank = (color == ChessColor.Black) ? 8 : 1;
			pieces[2] = rookA = new Rook(color, new Position(rank, 'a'));
			pieces[6] = knightB = new Knight(color, new Position(rank, 'b'));
			pieces[4] = bishopC = new Bishop(color, new Position(rank, 'c'));
			pieces[0] = king = new King(color, new Position(rank, 'd'));
			pieces[1] = queen = new Queen(color, new Position(rank, 'e'));
			pieces[5] = bishopF = new Bishop(color, new Position(rank, 'f'));
			pieces[7] = knightG = new Knight(color, new Position(rank, 'g'));
			pieces[3] = rookH = new Rook(color, new Position(rank, 'h'));
			
			rank = (color == ChessColor.Black) ? 7 : 2;
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


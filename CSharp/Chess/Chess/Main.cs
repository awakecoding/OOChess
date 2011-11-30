using System;

namespace Chess
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ChessSet blackSet = new ChessSet(ChessColor.Black);
			ChessSet whiteSet = new ChessSet(ChessColor.White);
			
			Console.WriteLine("Hello Chess!");
			
			foreach (ChessPiece piece in blackSet.pieces)
			{
				Console.WriteLine(piece);
			}
			
			foreach (ChessPiece piece in whiteSet.pieces)
			{
				Console.WriteLine(piece);
			}
		}
	}
}

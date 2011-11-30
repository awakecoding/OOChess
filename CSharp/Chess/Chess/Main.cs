using System;

namespace Chess
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Set blackSet = new Set(Color.Black);
			Set whiteSet = new Set(Color.White);
			
			Console.WriteLine("Hello Chess!");
			
			foreach (Piece piece in blackSet.pieces)
			{
				Console.WriteLine(piece);
			}
			
			foreach (Piece piece in whiteSet.pieces)
			{
				Console.WriteLine(piece);
			}
		}
	}
}

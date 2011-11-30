package chess;

public class Main
{
	public static void main(String args[])
	{
		Set blackSet;
		Set whiteSet;
		Piece[] pieces;
		
		System.out.println("hello chess!");
		
		blackSet = new Set(Color.Black);
		whiteSet = new Set(Color.White);
		
		for (Piece piece : blackSet.getPieces())
		{
			System.out.println(piece);
		}
		
		for (Piece piece : whiteSet.getPieces())
		{
			System.out.println(piece);
		}
	}
}

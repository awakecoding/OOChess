package chess;

public class Pawn extends Piece
{
	public Pawn(Color color, Position position)
	{
		super(color, position);
	}
	
	public String GetName()
	{
		return "Pawn";
	}
}

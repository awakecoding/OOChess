package chess;

public class Queen extends Piece
{
	public Queen(Color color, Position position)
	{
		super(color, position);
	}
	
	public String GetName()
	{
		return "Queen";
	}
}

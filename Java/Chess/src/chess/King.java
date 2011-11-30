package chess;

public class King extends Piece
{
	public King(Color color, Position position)
	{
		super(color, position);
	}
	
	public String GetName()
	{
		return "King";
	}
}

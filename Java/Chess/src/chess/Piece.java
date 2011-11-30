package chess;

public abstract class Piece
{
	private Color color;
	private Position position;
	
	public Piece(Color color, Position position)
	{
		this.color = color;
		this.position = position;
	}
	
	public abstract String GetName();
	
	public String toString()
	{
		return color + " " + GetName() + " (" + position + ")";
	}
}

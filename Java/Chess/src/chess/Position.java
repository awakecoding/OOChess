package chess;

public class Position
{
	private int rowIndex;
	private int colIndex;
	
	private int rank; /* row */
	private char file;  /* column */
	
	public Position(int rowIndex, int colIndex)
	{
		setRowIndex(rowIndex);
		setColIndex(colIndex);
	}
	
	public Position(int rank, char file)
	{
		setRank(rank);
		setFile(file);
	}
	
	public void setRowIndex(int rowIndex)
	{
		if (rowIndex >= 0 && rowIndex <= 8)
		{
			this.rowIndex = rowIndex;
			this.rank = rowIndex + 1;
		}
	}
	
	public void setColIndex(int colIndex)
	{
		if (colIndex >= 0 && colIndex <= 8)
		{
			this.colIndex = colIndex;
			this.file = (char) (colIndex + 0x61);
		}
	}
	
	public void setRank(int rank)
	{
		if (rank > 0 && rank <= 8)
		{
			this.rank = rank;
			this.rowIndex = rank - 1;
		}
	}
	
	public void setFile(char file)
	{
		if (file >= 'a' && file <= 'h')
		{
			this.file = file;
			this.colIndex = (((int) file) - 0x61);
		}
	}
	
	public String toString()
	{
		return rank + String.valueOf(file);
	}
}

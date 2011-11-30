using System;

namespace Chess
{
	public class Position
	{
		private int rowIndex;
		private int colIndex;
		
		private int rank; /* row */
		private char file; /* column */
		
		public Position(int rowIndex, int colIndex)
		{
			RowIndex = rowIndex;
			ColIndex = colIndex;
		}
		
		public Position(int rank, char file)
		{
			Rank = rank;
			File = file;
		}
		
		public int RowIndex
		{
			get { return rowIndex; }
			
			set
			{
				if (value >= 0 && value < 8)
				{
					rowIndex = value;
					rank = rowIndex + 1;
				}
			}
		}
		
		public int ColIndex
		{
			get { return colIndex; }
			
			set
			{
				if (value >= 0 && value < 8)
				{
					colIndex = value;
					file = (char) (colIndex + 0x61);
				}
			}
		}
		
		public int Rank
		{
			get { return rank; }
			
			set
			{
				if (value >= 1 && value <= 8)
				{
					rank = value;
					rowIndex = rank - 1;
				}
			}
		}
		
		public char File
		{
			get { return file; }
			
			set
			{
				if (value >= 'a' && value <= 'h')
				{
					file = value;
					colIndex = ((int) file) - 0x61;
				}
				else if (value >= 'A' && value <= 'H')
				{
					file = value;
					colIndex = ((int) file) - 0x41;
				}
			}
		}
		
		public override string ToString()
		{
			return Rank + File.ToString();
		}
	}
}


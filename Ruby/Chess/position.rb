
class Position
  
  def initialize(row, col)
    if (col.kind_of? Integer)
      setRowIndex(row)
      setColIndex(col)
    else
      setRank(row)
      setFile(col)
    end
  end
  
  def setRowIndex(rowIndex)
    if (rowIndex >= 0 && rowIndex <= 8)
      @rowIndex = rowIndex
      @rank = @rowIndex + 1
    end
  end
  
  def setColIndex(colIndex)
    if (colIndex >= 0 && colIndex <= 8)
      @colIndex = colIndex
      @file = colIndex + 0x61
    end
  end
  
  def setRank(rank)
    if (rank > 0 && rank <= 8)
      @rank = rank
      @rowIndex = rank - 1
    end
  end
  
  def setFile(file)
    if (file >= 'a' && file <= 'h')
      @file = file
      @colIndex = @file.ord() - 0x61
    end
  end
  
  def to_s()
    return @rank.to_s() + @file
  end
  
end

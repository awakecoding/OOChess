
require './king'
require './queen'
require './rook'
require './knight'
require './bishop'

class Set
  
  def initialize()
    @king = King.new()
    @queen = Queen.new()
  end
  
  def GetKing()
    return @king
  end
  
  def GetQueen()
    return @queen
  end

end

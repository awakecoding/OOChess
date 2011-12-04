
require './position.rb'

class Piece
  
  def initialize(color, position)
    @name = "Piece"
    @color = color
    @position = position
  end
  
  def GetName()
    return @name
  end
  
  def to_s
    return @color + " " + GetName() + " (" + @position.to_s() + ")"
  end
  
end

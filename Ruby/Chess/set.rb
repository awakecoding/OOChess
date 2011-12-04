
require './king'
require './queen'
require './rook'
require './knight'
require './bishop'
require './pawn'

class Set
  
  def initialize(color)
    @color = color
    @pieces = Array.new(16)
    
    rank = (color.eql? "Black") ? 8 : 1
    @pieces[0] = @rookA = Rook.new(@color, Position.new(rank, 'a'))
    @pieces[1] = @knightA = Knight.new(@color, Position.new(rank, 'b'))
    @pieces[2] = @bishopA = Bishop.new(@color, Position.new(rank, 'c'))
    @pieces[3] = @king = King.new(@color, Position.new(rank, 'd'))
    @pieces[4] = @queen = Queen.new(@color, Position.new(rank, 'e'))
    @pieces[5] = @bishopB = Bishop.new(@color, Position.new(rank, 'f'))
    @pieces[6] = @knightB = Knight.new(@color, Position.new(rank, 'g'))
    @pieces[7] = @rookB = Rook.new(@color, Position.new(rank, 'h'))
    
    rank = (color.eql? "Black") ? 7 : 2
    @pieces[8] = @pawnA = Pawn.new(@color, Position.new(rank, 'a'))
    @pieces[9] = @pawnB = Pawn.new(@color, Position.new(rank, 'b'))
    @pieces[10] = @pawnC = Pawn.new(@color, Position.new(rank, 'c'))
    @pieces[11] = @pawnD = Pawn.new(@color, Position.new(rank, 'd'))
    @pieces[12] = @pawnE = Pawn.new(@color, Position.new(rank, 'e'))
    @pieces[13] = @pawnF = Pawn.new(@color, Position.new(rank, 'f'))
    @pieces[14] = @pawnG = Pawn.new(@color, Position.new(rank, 'g'))
    @pieces[15] = @pawnH = Pawn.new(@color, Position.new(rank, 'h'))
  end
  
  def GetPieces()
    return @pieces
  end

end

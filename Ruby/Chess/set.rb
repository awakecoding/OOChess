
require './king'
require './queen'
require './rook'
require './knight'
require './bishop'
require './pawn'

class Set
  
  def initialize()
    
    @pieces = Array.new(16);
    
    @pieces[0] = @rookA = Rook.new()
    @pieces[1] = @knightA = Knight.new()
    @pieces[2] = @bishopA = Bishop.new()
    @pieces[3] = @king = King.new()
    @pieces[4] = @queen = Queen.new()
    @pieces[5] = @bishopB = Bishop.new()
    @pieces[6] = @knightB = Knight.new()
    @pieces[7] = @rookB = Rook.new()
    
    @pieces[8] = @pawnA = Pawn.new()
    @pieces[9] = @pawnB = Pawn.new()
    @pieces[10] = @pawnC = Pawn.new()
    @pieces[11] = @pawnD = Pawn.new()
    @pieces[12] = @pawnE = Pawn.new()
    @pieces[13] = @pawnF = Pawn.new()
    @pieces[14] = @pawnG = Pawn.new()
    @pieces[15] = @pawnH = Pawn.new()
  end
  
  def GetKing()
    return @king
  end
  
  def GetQueen()
    return @queen
  end
  
  def GetPieces()
    return @pieces
  end

end

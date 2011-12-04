
require './set'

puts "hello, chess!"

blackSet = Set.new("Black");
whiteSet = Set.new("White");

blackSet.GetPieces().each{ |piece| puts piece.to_s }
whiteSet.GetPieces().each{ |piece| puts piece.to_s }

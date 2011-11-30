
require './set'

puts "hello, chess!"

blackSet = Set.new;

blackSet.GetPieces().each{|piece| puts piece.to_s }

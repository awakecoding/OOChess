
(defclass pos ()
  (
    (row-index
      :accessor pos-row-index
      :initarg row-index
      :initform 0)
    (col-index
      :accessor pos-col-index
      :initarg col-index
      :initform 0)
    (rank
      :accessor pos-rank
      :initarg rank
      :initform 1)
    (file
      :accessor pos-file
      :initarg file
      :initform "a")))

(defclass piece ()
  (
    (name
      :accessor piece-name
      :initarg name
      :initform "Piece")
    (color
      :accessor piece-color
      :initarg color
      :initform 1)))

(defclass king (piece)
  ((name :initform "King")))

(defclass queen (piece)
  ((name :initform "Queen")))

(defclass rook (piece)
  ((name :initform "Rook")))

(defclass knight (piece)
  ((name :initform "Knight")))

(defclass bishop (piece)
  ((name :initform "Bishop")))

(defclass pawn (piece)
  ((name :initform "Pawn")))

(setf _piece (make-instance 'piece))
(setf _king (make-instance 'king))
(setf _queen (make-instance 'queen))
(setf _rook (make-instance 'rook))
(setf _knight (make-instance 'knight))
(setf _bishop (make-instance 'bishop))
(setf _pawn (make-instance 'pawn))

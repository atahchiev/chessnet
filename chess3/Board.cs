using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess3
{
    public class Board
    {
        private const int heigth = 8;
        private const int weigth = 9;

        private IPiece[,] board;

        public IPiece[,] Board
        {
            get
            {
                return board;

            }
           
        }

        public Board ()
	    {
            board = new IPiece[heigth, weigth];

            board[0,0] = new Rook(0,0,'b');
            board[0,1] = new Knight(0,1,'b');
            board[0,2] = new Bishop(0,2,'b');
            board[0,3] = new Queen(0,3,'b');
            board[0,4] = new King(0,4,'b');
            board[0,5] = new Queen(0,5,'b');
            board[0,6] = new Bishop(0,6,'b');
            board[0,7] = new Knight(0,7,'b');
            board[0,8] = new Rook(0,8,'b');
            for (int i = 0 ; i < 9; i++){
                board[1,i] = new Pawn(1, i, 'b');
            }

            for (int i = 0 ; i < 9; i++){
                board[6,i] = new Pawn(6, i, 'w');
            }
            board[7,0] = new Rook(7,0,'w');
            board[7,1] = new Knight(7,1,'w');
            board[7,2] = new Bishop(7,2,'w');
            board[7,3] = new Queen(7,3,'w');
            board[7,4] = new King(7,4,'w');
            board[7,5] = new Queen(7,5,'w');
            board[7,6] = new Bishop(7,6,'w');
            board[7,7] = new Knight(7,7,'w');
            board[7,8] = new Rook(7,8,'w');

    	}

        /*
        bool movePiece(IPiece piece, int x, int y)
        {

        }


            

    bool checkIsValidMove(IPiece)
        
        }*/
}

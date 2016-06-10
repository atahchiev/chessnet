using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess3
{
    interface IPiece
    {
        int x;
        int y;
        char color;
        bool checkIsValidMove(int x,int y);

    }


    class Pawn
    {
        void movePiece(Pawn pawn, int x, int y)
        {


        }

    }
    class Knight
    {
        void movePiece(Rook rook, int x, int y)
        {

        }

    }
    class Bishop
    {
        void movePiece(Bishop bishop, int x, int y)
        {

        }

    }
    class Rook
    {
        void movePiece(Rook rook, int x, int y)
        {

        }

    }
    
    class Queen
    {
        void movePiece(Queen rook, int x, int y)
        {

        }

    }
}

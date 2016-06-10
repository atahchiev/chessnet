using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess3
{
    interface IPiece
    {
        void movePiece();

    }

    class Board
    {
        IPiece [][];
    }

    class Pawn
    {
        int x;
        int y;
        char color;
        void movePiece(Pawn pawn, int x, int y)
        {


        }

    }
    class Knight
    {
        int x;
        int y;
        char color;
        void movePiece(Rook rook, int x, int y)
        {

        }

    }
    class Bishop
    {
        int x;
        int y;
        char color;
        void movePiece(Bishop bishop, int x, int y)
        {

        }

    }
    class Rook
    {
        int x;
        int y;
        char color;
        void movePiece(Rook rook, int x, int y)
        {

        }

    }
    
    class Queen
    {
        int x;
        int y;
        char color;
        void movePiece(Queen rook, int x, int y)
        {

        }

    }
}

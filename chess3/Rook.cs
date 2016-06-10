using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess3
{
    public class Rook : IPiece
    {
        private int x;
        private int y;
        private char color;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                if (value < 0 || value > 9)
                {
                    x = value;
                }

            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                if (value < 0 || value > 8)
                {
                    y = value;
                }
            }
        }

        public char Color
        {
            get
            { return color; }
            set
            {
                if(value == 'w' || value == 'b')
                {
                    color = value;
                }
            }
        }

        public Rook(int x=0, int y=0, char color='w')
        {
            this.x = x;
            this.y = y;
            this.color = color;

        }

        bool checkIsValidMove(int _x, int _y)
        {
            if((this.x == _x && _y > 0 && _y < 9) || (this.y == _y && _x > 0 && _x < 8))
            {
                return true;
            }
            return false;
        }


    }
}

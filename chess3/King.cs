using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess3
{
    public class King : IPiece
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

        public King(int x=0, int y=0, char color='w')
        {
            this.x = x;
            this.y = y;
            this.color = color;

        }

        bool checkIsValidMove(int _x, int _y)
        {
            if((this.x == _x && (_y == this.y + 1 || _y == this.y - 1)) || (this.y == _y && (_x == this.x + 1 || _x == this.x - 1)))
            {
                return true;
            }
            return false;
        }

    }
}

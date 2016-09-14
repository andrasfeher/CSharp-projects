using System;
using System.Collections.Generic;
using System.Text;

namespace tictac
{
    class Position
    {
        private int _x;
        private int _y;

        public Position( int x, int y )
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Diem
{
    internal class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point() { }

        public Point(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public double Distance()
        {
            return Math.Sqrt(1.0 * x * x + 1.0 * y * y);
        }
    }
}

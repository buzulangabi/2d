using System;
using System.Collections.Generic;
using System.Text;

namespace probseg_2d
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point point)
        {
            if (X == point.X && Y == point.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

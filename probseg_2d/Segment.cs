using System;
using System.Collections.Generic;
using System.Text;

namespace probseg_2d
{
    public class Segment
    {
        public Point Start { get; set; }
        public Point End { get; set; }


        public Segment(Point start, Point end)

        {
            Start = start;
            End = end;
        }

        public Segment(double x1, double y1, double x2, double y2)
        {
            Start = new Point(x1, y1);
            End = new Point(x2, y2);


        }

        private bool FindIntersection(Segment segment)
        {
            // Get the segments' parameters.
            double dx12 = End.X - Start.X;
            double dy12 = End.Y - Start.Y;
            double dx34 = End.X - Start.X;
            double dy34 = End.Y - Start.Y;

            // Solve for t1 and t2
            double denominator = (dy12 * dx34 - dx12 * dy34);

            double t1 =
                ((Start.X - Start.X) * dy34 + (Start.Y - Start.Y) * dx34)
                / denominator;
            if (double.IsInfinity(t1))
            {
                // The lines are parallel (or close enough to it).
                return false;
            }

            double t2 =
                ((Start.X - Start.X) * dy12 + (Start.Y - Start.Y) * dx12)
                / -denominator;

            return
                ((t1 >= 0) && (t1 <= 1) &&
                 (t2 >= 0) && (t2 <= 1));
        }
    }




}


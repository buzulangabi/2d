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

    }




}


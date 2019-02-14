using System;

namespace probseg_2d
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point start = new Point(x: 2, y: 5);
            Point end = new Point(x: 6, y: 8);




            Segment segment = new Segment(start, end);

            Segment segment2 = new Segment(x1: 5, y1: 9, x2: 6, y2: 8);
        }
    }
}

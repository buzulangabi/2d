using System;

namespace probseg_2d
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Point start = new Point(x: 2, y: 5);
            //Point end = new Point(x: 6, y: 8);




            //Segment segment = new Segment(start, end);

            Segment segment2 = new Segment(x1: 2, y1: 2, x2: 4, y2: 6);

            Segment segment3 = new Segment(new Point(x: 4, y: 6), new Point(x: 6, y: 7));
            Segment segment4 = new Segment(new Point(x: 9, y: 9), new Point(x: 14, y: 12));
            Segment segment5 = new Segment(new Point(x: 1, y: 2), new Point(x: 3, y: 3));
            Segment segment6 = new Segment(new Point(x: 3, y: 3), new Point(x: 4, y: 2));
            Segment segment7 = new Segment(new Point(x: 4, y: 2), new Point(x: 3, y: 1));

             
            Path path = new Path();
            path.AddSegment(segment5);
            path.AddSegment(segment6);
            path.AddSegment(segment7);
            //path.AddSegments(segment4);

            var raspuns = path.GetCircuit();
        
            //Path path2 = new Path();
            //path2.GetCircuit();


        }

    }
}

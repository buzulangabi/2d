using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace probseg_2d
{
    public class Path
    {
        List<Segment> ListaDeSegmente = new List<Segment>();

        public void AddSegment(Segment segment)
        {
            if (CanAddSegments(segment))
            {
                 ListaDeSegmente.Add(segment);
            }
            else
            {
               throw new ArgumentException($"Segmentul introdus nu poate fi adaugat", "canAddSegments");
            }
        }
        
        public bool CanAddSegments(Segment segment)
        {
            if (!ListaDeSegmente.Any())
            {
                return true;
            }


            var ultimulElement = ListaDeSegmente.Last();

            if (!segment.Start.Equals(ultimulElement.End))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}



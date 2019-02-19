using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace probseg_2d
{
    public class Path
    {
        List<Segment> ListaDeSegmente = new List<Segment>();

        public Openclose GetCircuit()
        {
            var primulSegment = ListaDeSegmente.First();
            var ultimulSegment = ListaDeSegmente.Last();

            if (!ListaDeSegmente.Any())
            {
                return Openclose.NoSegments;

            }

            if (ListaDeSegmente.Count == 1)
            {
                return Openclose.Deschis;
            }

            if (primulSegment.Start.Equals(ultimulSegment.End))
            {
                return Openclose.Inchis;
            }
            else
            {
                return Openclose.Deschis;
            }


        }

        public void AddSegments(List<Segment> listaDeSegmente)
        {

            foreach (Segment segment in listaDeSegmente)
            {
                AddSegment(segment);
            }
        }

        public void AddSegment(Segment segment)
        {
            if (CanAddSegment(segment))
            {
                ListaDeSegmente.Add(segment);
            }
            else
            {
                throw new ArgumentException($"Segmentul introdus nu poate fi adaugat", "canAddSegments");
            }
        }

        public bool CanAddSegment(Segment segment)
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



using System;
using Задание_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Segment
    {
        private Point pStart;
        private Point pEnd;

        public Segment(Point pStart, Point pEnd)
        {
            this.pStart = pStart;
            this.pEnd = pEnd;
        }
        public Segment()
        { 
        
        }
        public void Show()
        {
            Console.WriteLine($"Отрезок с координатами: {pStart}-{pEnd}", pStart, pEnd);
        }
        public double Length()
        {
            return pStart.Interval(pEnd);
        }
    }
}

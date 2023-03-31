using System;
using Задание_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.Show();
            Point p2 = new Point(12, 13);
            p2.Show();
            Segment r = new Segment(p1, p2);
            r.Show();
            double d = r.Length();
            Console.WriteLine($"Длина отрезка: {d}", d);
            Console.ReadLine();
        }
    }
}

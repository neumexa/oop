using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progression
{
    internal class Program
    {
        static void Main()
        {
            ArithmeticProgression p1 = new ArithmeticProgression(30, 20);
            Console.WriteLine(p1.GetElement(2));
            GeometricProgression p2 = new GeometricProgression(12, 2);
            Console.WriteLine(p2.GetElement(4));
            Console.ReadLine();
        }
    }
}

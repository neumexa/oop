using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Program
    {
        static void Main()
        {
            Ellipse F1 = new Ellipse(13, 6);
            Rectangle F2 = new Rectangle(7, 8);
            Console.WriteLine("Площадь Эллипса: " + F1.Area());
            Console.WriteLine(F2.Area());
            Console.ReadLine();
        }
    }
}

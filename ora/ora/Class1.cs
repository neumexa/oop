using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 5, 6);
        Console.WriteLine("\nA =3");
        Console.WriteLine("\nB =5");
        Console.WriteLine("\nC =6");
        Console.WriteLine("\nПлощадь треугольника: " + triangle.Area() + "см");
        Console.WriteLine("\nПериметр треугольника: " + triangle.Perimetr() + "см");
    }
}
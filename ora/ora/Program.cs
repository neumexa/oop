using System;
class Triangle
{

    public double a { get; set; }
    public double b { get; set; }
    public double c { get; set; }

    public Triangle()
    {
    }

    public bool isTriangle
    {
        get
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

    }

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Area()
    {
        return (a * b) / 2;
    }

    public double Perimetr()
    {
        return a + b + c;
    }
}
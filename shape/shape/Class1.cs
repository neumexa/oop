using System;

abstract class Shape
{
    public abstract double Area();
}

class Ellipse : Shape
{
    private double a;
    private double b;

    public Ellipse(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override double Area()
    {
        return Math.PI * a * b;
    }
}

class Rectangle : Shape
{
    private double c;
    private double d;

    public Rectangle(double c, double d)
    {
        this.c = c;
        this.d = d;
    }

    public override double Area()
    {
        return c * d;
    }
}

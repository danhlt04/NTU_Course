using System;
using Diem;

internal class Circle
{
    private double r;
    private Point c;

    public double R
    {
        get { return r; }
        set { r = value; }
    }

    public Point C
    {
        get { return c; }
        set { c = value; }
    }

    public Circle() { }

    public Circle(double R, Point C)
    {
        r = R;
        c = C;
    }

    public double Area()
    {
        return Math.PI * r * r;
    }

    public void Move(int dx, int dy)
    {
        c.X += dx;
        c.Y += dy;
    }
}

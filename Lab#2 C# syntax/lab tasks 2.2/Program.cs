using System;

class quadrilateral
{
    double l1;
    double l2;
    double h1;
    double h2;

    public void set_value(double l1, double h1)
    {
        this.l1 = l1;
        l2 = l1;
        this.h1 = h1;
        h2 = h1;
    }
    double get_l1() { return l1; }
    double get_l2() { return l2; }
    double get_h1() { return h1; }
    double get_h2() { return h2; }

    public void area()
    {
        double a;
        a = l1 * h1;
        Console.WriteLine("the area of Quadrilatreal is: " + a);

    }
    public void parameter()
    {
        double p;
        p = l1 + l2 + h1 + h2;
        Console.WriteLine("the area of Quadrilatreal is: " + p);
    }

    public void display()
    {
        Console.WriteLine("length of side 1 is: " + get_l1());
        Console.WriteLine("length side 3 is: " + get_l2());
        Console.WriteLine("length side 2 is: " + get_h1());
        Console.WriteLine("length side 4 is: " + get_h2());
        area();
        parameter();
    }
}
class program
{
    static void Main(string[] args)
    {
        quadrilateral shape = new quadrilateral();
        shape.set_value(21.8, 10.5);
        shape.display();
    }
}
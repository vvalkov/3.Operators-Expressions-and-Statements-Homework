using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter side 'a' of the Trapezoid:");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Enter side 'b' of the Trapezoid:");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Enter height 'h' of the Trapezoid:");
        double h = Double.Parse(Console.ReadLine());
        Console.WriteLine("Area of the Trapezoid is: {0}", (a + b) / 2 * h);
    }
}

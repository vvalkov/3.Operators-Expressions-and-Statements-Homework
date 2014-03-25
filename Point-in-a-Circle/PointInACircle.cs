using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please enter a point 'x' coordinates");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a point 'y' coordinates");
        double y = double.Parse(Console.ReadLine());
        bool isInACircle = (x * x + y * y <= 2 * 2);
        Console.WriteLine("Is the given point in the circle?\n{0}", isInACircle);
    }
}
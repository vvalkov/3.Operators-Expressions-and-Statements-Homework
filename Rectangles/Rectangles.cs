using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter rectangle's height");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter rectangle's width");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("The rectangle's Parameter is: {0}", (2*height)+(2*width));
        Console.WriteLine("The rectangle's Area is: {0}", (height*width));
    }
}

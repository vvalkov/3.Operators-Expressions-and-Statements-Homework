using System;

class InCircleOutRect
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a point 'x' coordinates");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a point 'y' coordinates");
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;

            bool isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= r * r);
            bool isInRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            if (isInCircle == true && isInRectangle == false)
            {
                Console.WriteLine("Yes, the point inside the circle and outside the rectangle.");
            }
            else
            {
                Console.WriteLine("No, the point is not inside the circle and outside the rectangle.");
            }
        }
    }
}
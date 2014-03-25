using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive number to be checked if it is prime");
        int num = int.Parse(Console.ReadLine());
        while (num < 2 || num > 100)
        {
            Console.WriteLine("Please enter a positive whole number which is <=100");
            num = int.Parse(Console.ReadLine());
        }

        bool isPrime = true;

        for (int i = 2; i < Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                Console.WriteLine("The number can be devided by {0}", i);
            }
        }
        Console.WriteLine("Is the number prime? \n{0}", isPrime);
    }
}
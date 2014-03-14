using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter an int number to be checked if it is even or odd");
                int firstValue = int.Parse(Console.ReadLine());
                if (firstValue % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }   
            }
           
                   
        }
    }

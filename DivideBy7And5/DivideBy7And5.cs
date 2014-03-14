using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Please enter an int number");
            int value = int.Parse(Console.ReadLine());
            bool result = ((value % 5 == 0) && (value % 7 == 0));
            Console.WriteLine(result);
        }
    }

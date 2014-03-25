using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter 4 digit number:");
        int number = int.Parse(Console.ReadLine());
        
        while (number > 9999 || number < 1000)
        {
            Console.WriteLine("The number must be 4 digits and cannot start with 0. Please, try again.");
            number = int.Parse(Console.ReadLine());
        }

        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;
        
        Console.WriteLine("The sum of digits is {0}", a+b+c+d);
        Console.WriteLine("The reversed digit number is {0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("The number with the last digit in first position is {0}{1}{2}{3}", d,a,b,c);
        Console.WriteLine("The number with exchanged second and third digits is {0}{1}{2}{3}", a,c,b,d);
    }
}
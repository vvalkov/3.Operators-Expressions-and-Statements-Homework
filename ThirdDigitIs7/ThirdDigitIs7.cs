using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter an int number");
        int value = int.Parse(Console.ReadLine());
        bool result = ((value / 100) % 10) == 7;
        Console.WriteLine(result);
    }
}

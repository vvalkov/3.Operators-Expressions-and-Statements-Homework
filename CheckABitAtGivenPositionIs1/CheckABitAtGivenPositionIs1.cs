using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        while (true)
        {      
        Console.WriteLine("Please enter integer number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position of the bit you would like to check if it is 1");
        int p = int.Parse(Console.ReadLine());
        int bit = (num >> p) & 1;
        bool result = (bit == 1);
        Console.WriteLine(result);
        }
    }
}
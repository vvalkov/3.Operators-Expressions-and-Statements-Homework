using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter integer number");
            int result = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the position of the bit you would like to extract");
            int p = int.Parse(Console.ReadLine());
            int bit = (result >> p) & 1;
            Console.WriteLine(bit);
        }
    }
}
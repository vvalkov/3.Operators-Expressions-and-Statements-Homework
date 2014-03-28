using System;

class ExtractBit3
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter positive int number");
            uint result = uint.Parse(Console.ReadLine());
            int bit = (int)(result >> 3) & 1;
            Console.WriteLine(bit);
        }
    }
}
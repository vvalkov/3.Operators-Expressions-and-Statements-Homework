using System;
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter integer number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the position of the bit you would like to extract");
            int p = int.Parse(Console.ReadLine());
            byte v = 0;
            do
            {
                Console.WriteLine("Please enter value of 1 or 0 for the bit you would like to exchange");
                v = byte.Parse(Console.ReadLine());
            } while (v != 0 && v != 1);
            n = n & (~(1 << p)) | (v << p);
            Console.WriteLine(n);
        }
    }
}
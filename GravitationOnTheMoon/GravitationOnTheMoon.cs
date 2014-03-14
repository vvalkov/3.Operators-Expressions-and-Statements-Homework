using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Please eneter your weight in kg");
            float kg = float.Parse(Console.ReadLine());
            Console.WriteLine(0.17 * kg);  
        }
    }

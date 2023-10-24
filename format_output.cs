using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // FORMATTING OUTPUT

            Console.WriteLine("Currency {0:c}", 23.456);
            Console.WriteLine("Pad With Zeroes {0:d4}", 23);
            Console.WriteLine("3 Decimals {0:f3}", 23.456);
            Console.WriteLine("Commas {0:n4}", 2300);
        }   
    }
}

using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: "); // Write to input in same line
            
            // To take input from user
            string name = Console.ReadLine();

            // To print variable inside string use $"Any Text {variable}"
            Console.WriteLine($"Hello {name}");
        }
    }
}

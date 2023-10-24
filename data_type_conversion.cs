using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CONVERT DATA TYPES
            bool boolFromStr = bool.Parse("true");
            Console.WriteLine($"boolFromStr = {boolFromStr}");

            int intFromStr = int.Parse("109");
            Console.WriteLine($"intFromStr = {intFromStr}");

            double doubleFromStr = double.Parse("109.56789");
            Console.WriteLine($"doubleFromStr = {doubleFromStr}");

            //To covert to string
            string strFromDouble = doubleFromStr.ToString();
            Console.WriteLine($"strFromDouble = {strFromDouble}");

            //To get type
            Console.WriteLine($"strFromDouble Type = {strFromDouble.GetType()}");

            //Explicit Type conversion as the value will be lost
            // Such that when we convert double to int the decimal value will be lost
            double doubleVar = 103.65879;
            Console.WriteLine("Explicit {0}", (int)doubleVar);

            // Implicit where we dont lose any value and
            // conversion happens generally from smaller to larger type
            int num = 1000056;
            long longNum = num;
            Console.WriteLine("Long int num : {0}", longNum);
            Console.WriteLine("Long int num TYPE : {0}", longNum.GetType());

            // INT is 32 bit and LONG is 64 bit
        }   
    }
}

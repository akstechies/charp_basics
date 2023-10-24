using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES and DATA TYPES
            bool canIVote = true;
            Console.WriteLine(canIVote);

            //Integer 32 or 64 bit
            // Another way to print value in string in Console is ("{0}", variable)
            Console.WriteLine("Smallest Interger {0}", int.MinValue);
            Console.WriteLine("Biggest Interger {0}", int.MaxValue);

            //Smallest and Longest Long - long is big than int 
            Console.WriteLine("Smallest Long {0}", long.MinValue);
            Console.WriteLine("Biggest Long {0}", long.MaxValue);

            // Decimal numbers -  28 digits in decimal part
            decimal varDecimal1 = 1.2562225M;
            decimal varDecimal2 = 2.5672737372821920393M;

            //Add it in string 
            Console.WriteLine("Add decimals {0}", varDecimal1 + varDecimal2);

            //Biggest decimal
            Console.WriteLine($"Biggest decimal {decimal.MaxValue}");

            //Doubles are 64 bit float type
            Console.WriteLine("Biggest Double {0}", Double.MaxValue); // Also double. can be used
            //Double precision is 14
            double adbl = 17.89;
            double bdbl = 190.34;
            Console.WriteLine("Double add {0}", adbl + bdbl);

            //FLOAT ends with F
            Console.WriteLine("Biggest Float {0}", float.MaxValue); // Also double. can be used
            //Float precision is 6 digits
            float afloat = 17.89F;
            float bFloat = 190.34F;
            Console.WriteLine("Float add {0}", afloat + bFloat);
        }
    }
}

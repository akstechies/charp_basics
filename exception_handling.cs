using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {

        static double DoDivide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        static void Main(string[] args)
        {
            // EXCEPTIONAL HANDLING

            // To catch errors that could crash our program
            int num1 = 5;
            int num2 = 0;

            try
            {
                Console.WriteLine(DoDivide(num1,num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cant divide by zero {0}: ", ex.Message);
            }

            // This will be executed no matter what is the exception
            finally { Console.WriteLine("Done");  }

        }
    }
}

using System;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        enum Color: byte
        {
            Orange = 1,
            Green,
            Blue,
            Red
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0} is {1}", Color.Green, (int)Color.Green);
        }
    }
}

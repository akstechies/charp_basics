using System;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // STRING BUILDERS

            // when change a string means creating a brand new string and is inefficient
            // if working with large blocks of text
            // So string builders allows to change text directly in memory rather than
            // making a new copy

            // By default size of 16 character but they automatically grow as needed

            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("Text with another size say 256", 256);

            // Capacity to get max number of chars that can be stored in memory
            Console.WriteLine("Capacity of sb: {0}", sb.Capacity);
            Console.WriteLine("Capacity of sb2: {0}", sb2.Capacity);

            //Length of character stored
            Console.WriteLine("Length of sb: {0}", sb.Length);

            //Append
            sb.AppendLine("--------Appended");
            Console.WriteLine(sb);

        }
    }
}

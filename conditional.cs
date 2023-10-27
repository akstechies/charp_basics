using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // CONDITIONAL
            // Relation Operators == != < > <= >= 
            // Logical Operators && || !

            int age = 19;

            if ((age >= 5) && (age <=7))
            {
                Console.WriteLine("Your are a kid aged {0}", age);
            } 
            else if ((age > 7) && (age <= 10)) 
            {
                Console.WriteLine("Your are a mid aged {0}", age);
            } 
            else
            {
                if( age > 10 || age%2 != 0)
                {
                    Console.WriteLine("Your are a odd aged {0}", age);
                }
                else if(age > 10 || age % 2 == 0)
                {
                    Console.WriteLine("Ewwww Adult aged {0}", age);
                }
            }

            // Ternary operator
            bool canDrive = age >= 18 ? true : false;
            Console.WriteLine(canDrive ? $"You can drived aged {age}" : $"You can't drived aged {age}");

            // Switch case -- better when limited number of options
            int caseVal = 6;
            switch (caseVal)
            {
                case 1: 
                case 2:
                    Console.WriteLine("case {0}", caseVal);
                    break;
                case 3: 
                case 4:
                    Console.WriteLine("case {0}", caseVal);
                    break;
                case 5:
                case 6:
                    goto caseMet; 
                default:
                    Console.WriteLine("Default");
                    break;
            }

        // FOR goto -- to jump to the mentioned keyword
        caseMet:
            Console.WriteLine("Goto {0}", caseVal);

            // String equals for comparison
            string name1 = "hello";
            string name2 = "bye";

            if(name2.Equals(name1, StringComparison.Ordinal))
            {
                Console.WriteLine($"{name1} and {name2} equal");
            }
            else
            {
                Console.WriteLine($"{name1} and {name2} NOT equal");
            }
        }
    }
}

using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // LOOPS

            // ------- While loop, execute while loop as long as the condition is true
            Console.WriteLine("WHILE");

            int i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue; // Don't execute further jump to next loop
                }
                if (i == 9) break; // Break the loop

                Console.WriteLine(i); // It will print even
                i++;
            }

            Console.WriteLine("-----------------------------------");
            // ------- DO WHILE LOOP - Execute the loop atleast one time
            Console.WriteLine("DO WHILE");

            int j = 5;
            do 
            { 
                Console.WriteLine(j);
                j++;
            } while (j < 9);

            // GUESS NUMBER GAME
            Console.WriteLine("--------------");
            Console.WriteLine("GUESS NUMBER GAME DO WHILE");

            Random random = new Random();
            int secretNumber = random.Next(1, 11);
            int guessNumber;
            do
            {
                Console.Write("Enter the number between 1 to 10: ");
                guessNumber = Convert.ToInt32(Console.ReadLine()); // Since input is in string so to convert in Int
                Console.WriteLine("Secret is: {0}", secretNumber);
                secretNumber = random.Next(1, 11);

            } while (guessNumber != secretNumber);
            Console.WriteLine("You gessed it: {0} = {1}", secretNumber, guessNumber);
        }
    }
}

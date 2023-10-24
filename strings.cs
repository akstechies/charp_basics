using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // STRINGS

            string randString = "This is a string";

            Console.WriteLine(randString);
            Console.WriteLine("Length {0}", randString.Length);
            Console.WriteLine("Contains {0}", randString.Contains("is"));

            //Remove chars - Error when start index or count not maches the chars
            Console.WriteLine("Remove chars at specific index: {0}", randString.Remove(10, 6)); //StartIndex, Count

            //Insert at index
            Console.WriteLine("Insert {0}", randString.Insert(10, "to insert "));

            // Replace the string and if the old string is not found then nothing will be replaced
            Console.WriteLine("Replace {0}", randString.Replace("string", "sentence"));

            // Compare String
            Console.WriteLine("Compare {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            // The last value is bool means that Case should be ignored or not during comparision

            // ======================
            Console.WriteLine("------------------------");

            //Check if strings are equal
            Console.WriteLine("Equal {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            //Add padding to string
            Console.WriteLine("Pad left: {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("Pad right: {0}", randString.PadRight(20, '.'));

            // Trim white space --leading and trailing
            Console.WriteLine("Trim: {0}", randString.Trim());

            //case change
            Console.WriteLine("Upper: {0}", randString.ToUpper());
            Console.WriteLine("Lower: {0}", randString.ToLower());

            // Format String
            string formatString = String.Format("{0} name {1} {2}", "My", "name", "Ayush");
            Console.WriteLine("formatString {0}", formatString);

            // Escape Characters like \n
            Console.WriteLine("--Hello Escape \n Character --");

            //Ignore escape using @
            Console.WriteLine(@"- Escape \n Character ignored --");
        }   
    }
}

using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS

            /* Arrays are just boxes inside of a bigger box
             * that can contain many values of the same
             * data type
             * Each item is assigned a key starting at 0
             * and incrementing up from there*/

            // Arrays contains same Data type but object arrays can contains different
            // Arrays have fixed sizes

            int[] nums = new int[10];
            nums[0] = 1;

            Console.WriteLine(nums[0]);

            //String arrays
            // Array can also be defined using curly brackets {}
            string[] names = {"Ayush", "Abhinav", "Anita", "Anand" };
            Console.WriteLine(names[1]);

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Bob", "Marley", "John" };
            Console.WriteLine(employees[0]);

            // Create an array of base objects which is the
            // base type of all other types
            object[] family = { "Ayush", 28, "Abhinav", 22 };
            Console.WriteLine(family[2]);

            //Get number of items in array - Length
            Console.WriteLine(family.Length);

            // Looping arrays
            for(int i = 0; i < family.Length; i++)
            {
                Console.WriteLine("Family At index {0}: {1}", i, family[i]);
            }

            // Multidimensional Arrays
            string[,] names2 = new string[2, 2] { 
                { "Ayush", "Abhinav" },
                { "Anita", "Anand" }
            };
            Console.WriteLine(names2.GetValue(1,0));

            // Foreach Array for loop
            foreach(string name in names)
            {
                Console.WriteLine("Foreach {0}", name);
            }

            Console.WriteLine("-------------------------------------");

            //ARRAY METHODS
            int[] arrayMethod = { 1,23,4,33,17};

            Array.Sort(arrayMethod);
            Console.WriteLine("Sort {0}", string.Join(", ", arrayMethod));

            Array.Reverse(arrayMethod);
            Console.WriteLine("Reverse {0}", string.Join(", ", arrayMethod));

            Console.WriteLine("Index of {0}", Array.IndexOf(arrayMethod, 4));

            int[] destArr = new int[3];
            Array.Copy(arrayMethod, 0, destArr, 0, destArr.Length);
            Console.WriteLine("Copied {0}", string.Join(", ", destArr));

            // Another way to create array is Array instance
            Array arrayInstance = Array.CreateInstance(typeof(int), 10);
            arrayMethod.CopyTo(arrayInstance, 3);
            foreach (var item in arrayInstance)
            {
                Console.WriteLine("Copied Instance! {0}", item);
            }

            // Search for we can do using Array.Find(arrayInstance, some_lambda_function)
        }
    }
}

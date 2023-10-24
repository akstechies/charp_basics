using System; //input namespace which has methods
    // Example instead of 
    // System.Console.WriteLine we can write Console.WriteLine

//Define our own namespace
namespace ConsoleApp1
{
    //define class - to have objects
    public class Program
    {
        // now create a main function that will run and create it static because for static
        // we don't need to call it by creating an object

        static void Main(string[] args) //void means the function will return NOthing
        {
            Console.WriteLine("Hello World");

            // To change console appearance such as color
            
            // To change text color
            Console.ForegroundColor = ConsoleColor.Black;

            // To change background color
            Console.BackgroundColor = ConsoleColor.White;
            // Above will only apply to text backgound and doesnot include Console.WriteLine("Hello World");

            //To apply color to whole - clear console but it will not print Console.WriteLine("Hello World");
            Console.Clear();

            // To also display Hello World - write it after Console Clear
            Console.WriteLine("Hello World!");
        }
    }
}

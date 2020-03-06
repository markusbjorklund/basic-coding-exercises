using System;
using System.IO;

namespace sandbox
{
    class Program
    {

// play in the sand

        static void Main(string[] args)
        {
            // Example #1
            // Read the file as one string.
            string text = File.ReadAllText("text.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("This was done with ReadAllText.");
            Console.WriteLine(text);

            //Print empty line for easier reading
            Console.WriteLine();

            // Example #2
            // Read each line of the file into a string array. 
            //Each element of the array is one line of the file.
            Console.WriteLine("This was done with ReadAllLines.");
            string[] lines = File.ReadAllLines("text.txt");

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

// stop playing

    }
}
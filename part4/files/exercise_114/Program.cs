using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {

          // start counter
          int counter = 0;
            while (true)
            {
                string line = Console.ReadLine();
                // count lines
                counter++;

                if (line == "end")
                {
                    break;
                }
            }
            // print number of lines
            Console.WriteLine(counter -1);
        }
    }
}
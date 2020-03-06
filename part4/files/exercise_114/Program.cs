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

                if (line == "end")
                {
                    break;
                }
                counter++;
            }
            // print number of lines
            Console.WriteLine(counter);
        }
    }
}
using System;
using System.Collections.Generic;

namespace exercise_112
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<TelevisionProgram> list = new List<TelevisionProgram>();
            while (true)
            {
                // name your show
                Console.Write("Name: ");
                string name = Console.ReadLine();
                // break on empty
                if (name == "")
                {
                    break;
                }
                // how long is the show
                Console.Write("Duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());

                // add names to the list
                list.Add(new TelevisionProgram(name, duration));
            }
            // tidy up with an empty line
            Console.WriteLine();

            // the longest show given by userinput
            Console.Write("Program's maximum duration? ");
            int durationMax = Convert.ToInt32(Console.ReadLine());

            // print what we want
            foreach (TelevisionProgram program in list)
            {
                if (durationMax >= program.duration)
                {
                    Console.WriteLine(program.name + ", " + program.duration + " minutes");
                }
            }
        }
    }
}





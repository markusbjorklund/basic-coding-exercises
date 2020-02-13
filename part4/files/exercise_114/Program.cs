using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
            }
            Console.WriteLine(line.Count());
        }
    }
}
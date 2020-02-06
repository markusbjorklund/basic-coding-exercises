using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
      // read from user
      while (true)
      {
        string asked = Console.ReadLine();
        //break if empty
        if (asked == "")
        {
          break;
        }
        // split at white space
        // create array
        string[] parts = asked.Split(" ");
        foreach (string line in parts)
        {
          Console.WriteLine(line);
        }

      }
    }
  }
}
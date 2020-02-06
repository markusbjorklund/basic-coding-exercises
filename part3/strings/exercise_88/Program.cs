using System;
using System.Collections.Generic;

namespace exercise_88
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
        Console.WriteLine(parts[0]);
      }
    }
  }
}
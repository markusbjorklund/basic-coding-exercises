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
        // string "asked" and split from white space
        // create array called "parts"
        string[] parts = asked.Split(" ");
        foreach (string line in parts)
        {
          Console.WriteLine(line);
        }

      }
    }
  }
}
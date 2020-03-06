using System;
using System.Collections.Generic;

namespace exercise_89
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
        // create array
        // split at white space
        string[] parts = asked.Split(" ");
        // get last part of string from array
        // array starts from 0, so -1 is needed
        int last = parts.Length -1;
        // print last part of string
        Console.WriteLine(parts[last]);
      }
    }
  }
}
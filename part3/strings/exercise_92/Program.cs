using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      // int age 
      int age = 0;
      int oldest = 0;
      // namegoodies
      string name = "";
      string longestName = "";
      int length = 0;
      int longest = 0;
      // read from user
      while (true)
      {
        string asked = Console.ReadLine();
        // break if empty
        if (asked == "")
        {
          break;
        }

        // split strings into parts[0] and parts[1]
        // split strings into name and birthdate
        string[] parts = asked.Split(",");
        // grab stuff for name
        name = parts[0];
        length = name.Length;
        // subtract birthdate from current year
        age = 2020 - Convert.ToInt32(parts[1]);
        // get longest name (had trouble with the order on these)
        if (longest < length) { longest = length; longestName = name; }
        // get age of oldest bastard
        if (oldest < age) { oldest = age; }
      }
      // print longest name

      Console.WriteLine("Longest name: " + longestName);
      // print oldest
      Console.WriteLine("Highest age: " + oldest);
    }
  }
}
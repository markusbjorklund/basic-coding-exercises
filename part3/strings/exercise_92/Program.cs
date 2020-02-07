using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      // age
      int age = 9999;
      // name
      string name = ("");
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        // split the string in parts[0] (name) and [1] (year of birth)
        string[] parts = input.Split(",");

        // get birthyear of oldest (doing it the Janne-way)
        if (age > Convert.ToInt32(parts[1]))
        {
          age = Convert.ToInt32(parts[1]);
        }

        // get longest name
        if (name.Length < parts[0].Length)
        {
          name = parts[0];
        }
      }
    // calculate age of oldest
    int oldest = 2020 - age;
    Console.WriteLine("Longest name: " + name);
    Console.WriteLine("Highest age: " + oldest);
    }
  }
}
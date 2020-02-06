using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> persons = new List<string>();
      //int oldest
      int oldest = 0;
      string name = "";
      // read from user
      while (true)
      {
        string asked = Console.ReadLine();
        //break if empty
        if (asked == "")
        {
          break;
        }

        // split strings into parts[0] and parts[1]
        // split strings into name and age
        string[] parts = asked.Split(",");

        // check if age is greater than oldest
        if (Convert.ToInt32(parts[1]) > oldest)
        {
          // if true oldest is now parts[1] value
          oldest = Convert.ToInt32(parts[1]);
          // get name of oldest person 
          name = parts[0];
        }
      }
      // print the name
      Console.WriteLine("Name of the oldest: " + name);

      foreach (string person in persons)
      {
        Console.WriteLine(person);
      }
    }
  }
}
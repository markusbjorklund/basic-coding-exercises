using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> persons = new List<string>();
      //int oldest
      int oldest = 0;
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

        //check if age is greater than oldest
        if (Convert.ToInt32(parts[1]) > oldest)
        {
          //if true oldest is now parts[1] value
          oldest = Convert.ToInt32(parts[1]);
        }
      }
      // print the oldest
      Console.WriteLine("Age of the oldest: " + oldest);

      foreach (string person in persons)
      {
        Console.WriteLine(person);
      }
    }
  }
}
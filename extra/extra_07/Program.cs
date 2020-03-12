using System;
using System.Collections.Generic;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      int counter = 0;
      // ask user for numbers/integers
      Console.WriteLine("Give integers, 'end' quits:");
      while (true)
      {

        // end loop on "end"
        string input = Console.ReadLine();
        if (input == "end")
        {
          break;
        }
        // if numbers collect them to counter and calculate sum
        int number = Convert.ToInt32(input);
        counter = number + counter;
      }
      // print the sum to console
      Console.WriteLine("Sum: " + counter);
    }
  }
}


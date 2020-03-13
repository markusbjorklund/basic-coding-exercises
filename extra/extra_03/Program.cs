using System;
using System.Collections.Generic;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // numbers we want answers on
      int sum = 0;
      int total = 1; // can't multiply with zero
      double average = 0;

      // set zero on run
      int userNumbers = 0;

      // ask user how many numbers
      Console.WriteLine("How many numbers?");
      int numAmount = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give " + numAmount + " numbers:");

      // loop until given numbercount is reached
      for (int i = 0; i < numAmount; i++)
      {
        userNumbers = Convert.ToInt32(Console.ReadLine());
        // gather the sum of numbers
        sum = userNumbers + sum;
        // calculate totals
        total = userNumbers * total;
        // calculate average (does not have to be in the loop)
        average = (double)sum / numAmount;
      }

      // do some printing
      Console.WriteLine("Their sum: " + sum);
      Console.WriteLine("Their total: " + total);
      Console.WriteLine("Their average: " + average);
    }
  }
}
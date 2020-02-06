using System;
using System.Collections.Generic;

namespace exercise_82
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = { 5, 1, 3, 4, 2 };
      PrintArrayInStars(array);
    }

    public static void PrintArrayInStars(int[] array)
    {
      // list the array
      for (int i = 0; i < array.Length; i++)
      {
        // number of stars
        for (int stars = 0; stars < array[i]; stars++)
        {
          // convert to stars
          Console.Write("*");
        }
        // give me some linebreaks
        Console.WriteLine();
      }

    }
  }
}
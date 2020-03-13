using System;

namespace extra_10
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // print the array to stars
      int[] array = { 5, 1, 3, 4, 2 };
      PrintArrayInStars(array);
    }

    // define the method
    public static void PrintArrayInStars(int[] array)
    {
      // call and list the array
      for (int i = 0; i < array.Length; i++)
      {
        // transform numbers to stars
        for (int stars = 0; stars < array[i]; stars++)
        {
          Console.Write("*");
        }
        // insert linebreaks for each row
        Console.WriteLine();
      }
    }
  }
}

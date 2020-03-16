using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "end")
        {
          break;
        }
        // convert to numbers
        int number = Convert.ToInt32(input);
        // calculate
        Console.WriteLine(number * number * number);
      }
    }
  }
}
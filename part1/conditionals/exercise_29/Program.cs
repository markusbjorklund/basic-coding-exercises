using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userNumFirst = Console.ReadLine();
      int intNumFirst = Convert.ToInt32(userNumFirst);

      Console.WriteLine("Give the second number!");
      string userNumSecond = Console.ReadLine();
      int intNumSecond = Convert.ToInt32(userNumSecond);

      if (intNumFirst > intNumSecond)
      {
        Console.WriteLine("The larger number is " + intNumFirst + "!");
      }
      else if (intNumFirst < intNumSecond)
      {
        Console.WriteLine("The larger number is " + intNumSecond + "!");
      }
      else if (intNumFirst == intNumSecond)
      {
        Console.WriteLine("They are equal!");
      }
    }
  }
}

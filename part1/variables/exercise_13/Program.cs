using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number!");
      string userInput = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userInput);
      Console.WriteLine("You gave " + doubleValue);
    }
  }
}

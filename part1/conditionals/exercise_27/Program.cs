using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();
      int intNumber = Convert.ToInt32(userInput);
      if (intNumber > 0)
      {
        Console.WriteLine("It is positive");
      }
      else 
      {
        Console.WriteLine("It is not positive");
      }
    }
  }
}

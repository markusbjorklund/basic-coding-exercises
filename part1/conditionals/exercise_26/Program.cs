using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string userInput = Console.ReadLine();
      int intAge = Convert.ToInt32(userInput);
      if (intAge < 1900)
      {
        Console.WriteLine("You're old");
      }
    }
  }
}

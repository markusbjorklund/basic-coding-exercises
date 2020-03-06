using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string userInputFirst = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string userInputSecond = Console.ReadLine();
      if (userInputFirst == userInputSecond)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }
    }
  }
}

using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Your speed:");
      string userInput = Console.ReadLine();
      int intSpeed = Convert.ToInt32(userInput);
      if (intSpeed > 120)
      {
        Console.WriteLine("Speeding!");
      }
    }
  }
}

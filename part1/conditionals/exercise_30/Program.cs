using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string userInput = Console.ReadLine();
      int intUserPercent = Convert.ToInt32(userInput);
    
      if (intUserPercent < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (intUserPercent <= 49)
      {
        Console.WriteLine("Fail");
      }
      else if (intUserPercent <= 59)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (intUserPercent <= 69)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (intUserPercent <= 79)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (intUserPercent <= 89)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (intUserPercent <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (intUserPercent > 100)
      {
        Console.WriteLine("Outstanding!");
      }  
    }
  }
}

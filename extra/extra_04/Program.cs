using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // ask user for input between 0 - 100
      Console.WriteLine("Give your percent [ 0 - 100]:");
      int userInput = Convert.ToInt32(Console.ReadLine());

      // grading users input with ifs

      // need to clean up this and make it somewhat shorter and less sucky

      if (userInput < 0) 
      {
        Console.WriteLine("Impossible");
      }
      else if (userInput < 50)
      {
        Console.WriteLine("Fail");
      }
      else if (userInput <= 75)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (userInput < 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else 
      {
        Console.WriteLine("Outstanding!");
      }
    }
  }
}

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

      if (userInput < 1) 
      {
        Console.WriteLine("Impossible");
      }
      else if (userInput < 50)
      {
        Console.WriteLine("Fail");
      }
      else if (userInput < 60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (userInput < 70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (userInput < 80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (userInput < 90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (userInput < 101)
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

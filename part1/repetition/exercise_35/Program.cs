using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true) 
      {
        Console.WriteLine("Give a number:");
        string userInput = Console.ReadLine();
        int userNumber = Convert.ToInt32(userInput);
        if (userNumber == 42)
        { 
          break;
        }
      }
    }
  }
}

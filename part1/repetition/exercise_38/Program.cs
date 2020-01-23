using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int countNegNumber = 0;
      while (true) 
      {
        Console.WriteLine("Give a number:");
        string userInput = Console.ReadLine();
        int userNumber = Convert.ToInt32(userInput);
        if (userNumber == 0)
        { 
          break;
        }
        if (userNumber < 0)
        {
          countNegNumber = countNegNumber +1;
        }  
      }
      Console.WriteLine("Total amount of negative numbers: " + countNegNumber);
    }
  }
}

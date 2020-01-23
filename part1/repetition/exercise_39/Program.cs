using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int countNumber = 0;
      while (true) 
      {
        Console.WriteLine("Give a number:");
        string userInput = Console.ReadLine();
        int userNumber = Convert.ToInt32(userInput);
        if (userNumber == 0)
        { 
          break;
        }
        if (userNumber > 0)
        {
          countNumber = countNumber +1;
        }  
      }
      Console.WriteLine("Total sum of numbers: " + countNumber);
    }
  }
}

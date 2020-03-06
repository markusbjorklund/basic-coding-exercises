using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sumNumbers = 0;
      while (true) 
      {
        Console.WriteLine("Give a number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 0)
        { 
          break;
        }
        else
        {
          sumNumbers = sumNumbers + userNumber;
        }  
      }
      Console.WriteLine("Total sum of numbers: " + sumNumbers);
    }
  }
}

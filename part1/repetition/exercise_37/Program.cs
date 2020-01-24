using System;

namespace exercise_37
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
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 0)
        { 
          break;
        }
        else
        {
          countNumber = countNumber +1;
        }  
      }
      Console.WriteLine("Total amount of numbers: " + countNumber);
    }
  }
}

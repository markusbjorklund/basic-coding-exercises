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
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == 42)
        { 
          break;
        }
      }
    }
  }
}

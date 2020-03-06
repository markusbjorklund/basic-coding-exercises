using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int firstNumber = Convert.ToInt32(Console.ReadLine());
      int secondNumber = Convert.ToInt32(Console.ReadLine());
      if (firstNumber > secondNumber)
      {
        Console.WriteLine(firstNumber + " is greater than " + secondNumber + ".");
      }
      else if (firstNumber < secondNumber)
      {
        Console.WriteLine(firstNumber + " is less than " + secondNumber + ".");
      }
      else
      {
        Console.WriteLine(firstNumber + " is equal to " + secondNumber + ".");
      }
    }
  }
}

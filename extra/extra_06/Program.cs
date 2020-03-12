using System;

namespace extra_06
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // einstein is in da house
      // let's do some math

      // ask user for two integers/numbers
      Console.WriteLine("Hello good lookin'. I am from Russia and my name is ComPjotr. \nGive me two numbers or I will kill you!");

      int numOne = Convert.ToInt32(Console.ReadLine());
      int numTwo = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Thank you! I, ComPjotr will now tell you the square root of the sum of your numbers. \n");

      // calculate sum of the integers/numbers
      int sum = numOne + numTwo;

      // print square root of the sum, if it's not less than zero
      if (sum > 0)
      {
        Console.WriteLine("The square root is " + Math.Sqrt(sum));
      }
      else
      {
        Console.WriteLine("ComPjotr malfunction. I am printing 0");
      }
    }
  }
}

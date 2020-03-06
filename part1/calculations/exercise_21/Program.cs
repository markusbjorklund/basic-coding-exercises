using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string numFirst = Console.ReadLine();
      int intValueFirst = Convert.ToInt32(numFirst);
      Console.WriteLine("Give the second number!");
      string numSecond = Console.ReadLine();
      int intValueSecond = Convert.ToInt32(numSecond);
      double average = (intValueFirst + intValueSecond) / 2.0;
      Console.WriteLine("The average is " + average);
    }
  }
}

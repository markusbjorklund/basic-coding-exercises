using System;

namespace exercise_20
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
      Console.WriteLine(intValueFirst + " * " + intValueSecond + " = " + (intValueFirst * intValueSecond));
    }
  }
}

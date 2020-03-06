using System;

namespace exercise_18
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
      Console.WriteLine("Give the third number!");
      string numThird = Console.ReadLine();
      int intValueThird = Convert.ToInt32(numThird);
      Console.WriteLine("The sum is " + (intValueFirst + intValueSecond + intValueThird));
    }
  }
}

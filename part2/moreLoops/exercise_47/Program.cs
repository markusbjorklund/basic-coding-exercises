using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int numFirst = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int numSecond = Convert.ToInt32(Console.ReadLine());
      int start = numSecond;
      while (start <= numFirst)
      {
        Console.WriteLine(start);
        start++;
      }
    }
  }
}

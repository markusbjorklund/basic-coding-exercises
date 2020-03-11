using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // ask user for three numbers:
      Console.WriteLine("Give three numbers:");
      int numOne = Convert.ToInt32(Console.ReadLine());
      int numTwo = Convert.ToInt32(Console.ReadLine());
      int numThree = Convert.ToInt32(Console.ReadLine());
      // find the biggest number and print it
      if (numOne > numTwo && numOne > numThree)
      {
        Console.WriteLine("Largest: " + numOne);
      }
      else if (numTwo > numOne && numTwo > numThree)
      {
        Console.WriteLine("Largest: " + numTwo);
      }
      else
      {
        Console.WriteLine("Largest: " + numThree);
      }
    }
  }
}

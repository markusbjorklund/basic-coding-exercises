using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userNumber = Convert.ToInt32(Console.ReadLine());
      int start = userNumber;
      int end = 100;
      for (int numbers = start; numbers <= end; numbers++)
      {
        Console.WriteLine(numbers);
      }
    }
  }
}

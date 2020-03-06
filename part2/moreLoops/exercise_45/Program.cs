using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userNumber = Convert.ToInt32(Console.ReadLine());
      int number = 0;
      while (number <= userNumber)
      {
        Console.WriteLine(number);
        number++;
      }
    }
  }
}

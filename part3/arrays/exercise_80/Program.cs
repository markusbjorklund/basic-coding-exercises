using System;
using System.Collections.Generic;

namespace exercise_80
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] numbers = { 5, 1, 3, 4, 2 };
      int sum = SumOfNumbersInArray(numbers);
      Console.WriteLine(sum);

    }

    public static int SumOfNumbersInArray(int[] numbers)
    {
      // start from scratch
      int sum = 0;
      // einstein-code
      for (int i = 0; i < numbers.Length; i++)
      {
        // do some math
        int number = numbers[i];
        sum = sum + number;
      }
      return (sum);
    }

  }
}
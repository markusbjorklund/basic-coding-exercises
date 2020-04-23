using System;
using System.Collections.Generic;
public class Program
{
  public static void Main(string[] args)
  {

    List<int> numbers = new List<int>();

    Random lotteryNumbers = new Random();

    for (int i = 0; i < 7; i++)
    {
      int number = lotteryNumbers.Next(1, 40);
      {
        while (numbers.Contains(number));
        numbers.Add(number);
      }

    }

    Console.WriteLine("##############   DEBUG   ###############");

    numbers.Sort();

    numbers.ForEach(Console.WriteLine);

  }
}



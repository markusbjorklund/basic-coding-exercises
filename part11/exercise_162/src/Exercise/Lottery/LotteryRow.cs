namespace Exercise
{
  using System.Collections.Generic;
  using System;

  public class LotteryRow
  {
    private List<int> numbers;

    public LotteryRow()
    {
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      if (this.numbers.Contains(number))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
      Random lotteryNumbers = new Random();

      for (int i = 0; i < 7; i++)
      {
        int number = lotteryNumbers.Next(1, 41);
        {
          if (!this.ContainsNumber(number));
          numbers.Add(number);
        }
      }
      // sort the numbers
      numbers.Sort();
    }
  }
}
using System;
using System.Collections.Generic;

namespace exercise_71
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

      Console.WriteLine("Search for? ");
      int search = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine(number + " is at index " + index);

      PrintIndexOf(list, search);
    }

    public static void PrintIndexOf(List<int> numbers, int search) 
    {
      foreach(int number in numbers)
      { 
      if (number == search)
      {
        Console.WriteLine(number + " is at index ");
      }
      }
      // int index = list.IndexOf(number);

      // int index = numbers.IndexOf(search);
      // Console.WriteLine(index);

      
    }
  }
}
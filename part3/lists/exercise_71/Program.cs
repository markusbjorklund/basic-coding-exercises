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

      PrintIndexOf(list, search);
    }

    public static void PrintIndexOf(List<int> numbers, int search) 
    {
      int index = numbers.IndexOf(search);
      foreach(int number in numbers)
      { 
      if (number == search)
      
      
      {
        //FAIL
        Console.WriteLine(number + " is at index " + numbers.IndexOf(number));

        // Console.WriteLine(index);
      }
      }      
    }
  }
}
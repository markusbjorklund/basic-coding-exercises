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



int greatest = list[0];

      for(int i = 0; i < list.Count; i++) 
      {
        int number = list[i];
        Console.WriteLine(greatest);
        // if (greatest < number) 
        // {
        //  greatest = number;
        // }
      }
      // Console.WriteLine("The greatest number: " + greatest);
    
      // Console.WriteLine("Search for? ");
      // int number = Convert.ToInt32(Console.ReadLine());
      // int index = list.IndexOf(number);

      // Console.WriteLine(index);

      // // while (list.Contains(number))
      // // {
      // //   Console.WriteLine(number + " is at index " + index);
      // // }
    }
  }
}

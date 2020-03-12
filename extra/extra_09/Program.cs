using System;
using System.Collections.Generic;

namespace extra_09
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // looping a list with different loops

      List<string> list = new List<string>();
      list.Add("This is a string");
      list.Add("This is magic");
      list.Add("THIS IS PATRICK!");

      // for loop
      Console.WriteLine("for loop");
      for (int i = 0; i < list.Count; i++)
      {
        Console.WriteLine(list[i]);
      }

      // while loop
      Console.WriteLine("\nwhile loop");
      int index = 0;
      while (index < list.Count)
      {
        Console.WriteLine(list[index]);
        index++;
      }

      // foreach loop
      Console.WriteLine("\nforeach loop");
      list.ForEach(Console.WriteLine);
    }
  }
}

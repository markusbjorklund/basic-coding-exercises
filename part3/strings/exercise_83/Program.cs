using System;
using System.Collections.Generic;

namespace exercise_83
{
  class Program
  {
    public static void Main(string[] args)
    {
      // ask user for candy
      Console.Write("Give a word: ");
      string candy = Console.ReadLine();
      // print user candy times three
      Console.WriteLine(candy + candy + candy);
    }
  }
}
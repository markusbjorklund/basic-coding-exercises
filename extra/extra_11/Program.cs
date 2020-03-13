using System;
using System.Collections.Generic;

namespace extra_11
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // ask user for sentence
      Console.WriteLine("Hello there! Give me a sentence:");
      string userSentence = Console.ReadLine();

      // split, loop and print the string
      string[] pieces = userSentence.Split(" ");
      for ( int i = 0; i < pieces.Length; i++)
      {
        Console.WriteLine(pieces[i]);
      }
    }
  }
}

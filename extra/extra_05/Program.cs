using System;
using System.Collections.Generic;

namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // get to work lazy boy
      // do the following
      // print numbers 1-5, for loop
      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine(i);
      }

      // ask user for words, stop on the word "end"
      // store the words in a list
      List<string> words = new List<string>();
      Console.WriteLine("Give words, 'end' quits:");
      while (true)
      {
        string userWords = Console.ReadLine();
        words.Add(userWords);
        if (userWords == "end")
        {
          break;
        }
      }

      // fancy line divider
      Console.WriteLine("--------------------------");

      // print contents of the list with a foreach loop
      foreach (string word in words)
      { 
        Console.WriteLine(word);
      }

    }
  }
}

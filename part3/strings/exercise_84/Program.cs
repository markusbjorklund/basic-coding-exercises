using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      // ask for user input
      Console.Write("Give a string: ");
      // take user input
      string userInput = Console.ReadLine();
      // compare with true
      if (userInput == "true")
      {
        Console.WriteLine("You got it right!");
      }
      else
      {
        Console.WriteLine("Try again!");
      }
    }
  }
}
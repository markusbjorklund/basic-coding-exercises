using System;

namespace extra_01 {
  class Program {
    public static void Main(string[] args) {
      // Add your code here:

      // ask user for input
      Console.WriteLine("What do you want to print?");
      // user inputs text
      string userInput = Console.ReadLine();
      // ask user for how many times
      Console.WriteLine("How many times do you want to print?");
      // a million of times says user  
      int numOfTimes = Convert.ToInt32(Console.ReadLine());

      // print what the method does to console
      PrintThis(numOfTimes, userInput);
    }

    public static void PrintThis(int numOfTimes, string userInput) {
      // loop numOfTimes 
      int i = 0;
      while (i < numOfTimes) {
        Console.WriteLine(userInput);
        i++;
      }
    }
  }
}
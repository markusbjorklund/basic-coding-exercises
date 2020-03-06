using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Speak, friend, and enter!");
      string noTrolls = Console.ReadLine();
      if (noTrolls == "Mellon")
      {
        Console.WriteLine("Welcome, friend!");
      }
      else
      {
        Console.WriteLine("They've got a cave troll!");
      }
    }
  }
}

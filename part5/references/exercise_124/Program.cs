using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
    Error syntax = new Error("Syntax", 10);
    Console.WriteLine(syntax);
    Error wrong = syntax;
    wrong.MoreWrong();
    Console.WriteLine(wrong);
    wrong = null;
    Console.WriteLine(wrong);
    wrong.MoreWrong();
    }
  }
}

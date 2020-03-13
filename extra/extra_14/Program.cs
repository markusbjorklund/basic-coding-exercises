using System;
using System.IO;

namespace extra_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      
      // read text.txt and print to console
      string text = File.ReadAllText("text.txt");
      Console.WriteLine(text);
    }
  }
}

using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Do something here

      Dictionary<string, string> nickname = new Dictionary<string, string>();
      nickname.Add("matthew", "matt");
      nickname.Add("michael", "mix");
      nickname.Add("arthur", "artie");

      foreach (KeyValuePair<string, string> kvp in nickname)
      {
        Console.WriteLine("{0}'s nickname is {1}",
          kvp.Key, kvp.Value);
      }
    }
  }
}
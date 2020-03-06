using System;
using System.Collections.Generic;

namespace exercise_74 {
  class Program {
    public static void Main (string[] args) {
      List<string> list = new List<string> ();
      while (true) {
        string input = Console.ReadLine ();
        if (input == "") {
          break;
        }
        list.Add (input);
      }
      // search for
      Console.WriteLine ("Search for?");
      string userInput = Console.ReadLine ();
      
      // and we found it
      if (list.Contains (userInput)) {
        Console.WriteLine (userInput + " was found!");

      // in case it is not found
      } else {
        Console.WriteLine (userInput + " was not found!");
      }
    }
  }
}
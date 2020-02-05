using System;
using System.Collections.Generic;

namespace exercise_73 {
  class Program {
    public static void Main (string[] args) {
      List<int> list = new List<int> ();
      while (true) {
        int input = Convert.ToInt32 (Console.ReadLine ());
        if (input == -1) {
          break;
        }
        list.Add (input);
      }

      // start from scratch
      int sum = 0;

      // count the numbers
      for (int i = 0; i < list.Count; i++) {
        int number = list[i];
        sum = sum + number;
      }
      Console.WriteLine ("Sum: " + sum);
    }
  }
}
using System;
using System.Collections.Generic;

namespace exercise_72 {
  class Program {
    public static void Main (string[] args) {
      List<int> list = new List<int> ();
      while (true) {
        int input = Convert.ToInt32 (Console.ReadLine ());
        if (input == 9999) {
          break;
        }
        list.Add (input);
      }

      // find the smallest number in the list
      int smallest = list[0];
      for (int i = 0; i < list.Count; i++) {
        int number = list[i];
        if (smallest > number) {
          smallest = number;
        }
      }
      Console.WriteLine ("Smallest number: " + smallest);

      // find the index of the smallest number
      for (int i = 0; i < list.Count; i++) {
        if (list[i] == smallest)
          Console.WriteLine ("Found at index: " + i);
      }
    }
  }
}
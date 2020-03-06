using System;
using System.Collections.Generic;

namespace exercise_135
{
  class Program
  {
    public static void Main(string[] args)
    {
      JokeManager manager = new JokeManager();
      UserInterface ui = new UserInterface(manager);
      ui.Start();
    }
  }
}
using System;
using System.Collections.Generic;

namespace exercise_135
{
  public class JokeManager
  {
    List<string> jokes = new List<string>();
    // add joke to the list
    public void AddJoke(string joke)
    {
      jokes.Add(joke);
    }
    // draw a random joke
    public string DrawJoke()
    {
      if (jokes.Count == 0)
        // no jokes in memory
        return "Jokes are in short supply.";
      else
      {
        Random draw = new Random();
        int index = draw.Next(0, jokes.Count);
        return jokes[index];
      }
    }
    // print jokes
    public void PrintJokes()
    {
      foreach (string joke in jokes)
      {
        Console.WriteLine(joke);
      }
    }
  }
}
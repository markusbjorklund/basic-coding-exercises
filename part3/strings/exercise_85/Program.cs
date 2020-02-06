using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      // username
      Console.WriteLine("Enter username:");
      string userName = Console.ReadLine();
      // password
      Console.WriteLine("Enter password:");
      string userPass = Console.ReadLine();
      // compare username and passwords
      if (  (userName == "alex" && userPass == "sunshine") | (userName == "emma" && userPass == "haskell")  )
      {
        // success
        Console.WriteLine("You have successfully logged in!");
      }
      else
      {
        // fail
        Console.WriteLine("Incorrect username or password!");
      }
    }
  }
}
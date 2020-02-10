using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account peakyBlinders = new Account("Legal betting company", 100.00);
      peakyBlinders.Deposit(20);
      Console.WriteLine(peakyBlinders.balance);
    }
  }
}




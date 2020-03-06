using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string userString = Console.ReadLine();

      Console.WriteLine("Give an integer:");
      string userInt = Console.ReadLine();
      int intValue = Convert.ToInt32(userInt);

      Console.WriteLine("Give a double:");
      string userDouble = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userDouble);

      Console.WriteLine("Give a boolean:");
      string userBoolean = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(userBoolean);

      Console.WriteLine("Your string: " + userString);
      Console.WriteLine("Your integer: " + intValue);
      Console.WriteLine("Your double: " + userDouble);
      Console.WriteLine("Your boolean: " + booleanValue);
    }
  }
}

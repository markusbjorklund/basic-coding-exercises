using System;
using System.Collections.Generic;

namespace extra_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // make a new list
      List<Person> kindergarten = new List<Person>();
      // create some persons
      Person mike = new Person("Mike");
      Person lilly = new Person("Lilly");
      // make lilly one year old
      lilly.GrowOlder(1);
      // add persons to the list
      kindergarten.Add(mike);
      kindergarten.Add(lilly);

      // print the whole list
      foreach (Person child in kindergarten)
      {
        Console.WriteLine(child);
      }
    }
  }
}

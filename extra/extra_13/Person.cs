using System;
using System.Collections.Generic;


namespace extra_13
{
  public class Person
  {
    public string name;
    private int age;

    public Person(string name)
    {
      this.name = name;
      this.age = 0;
    }

    // requires a return statement
    public int GrowOlder(int howMuch)
    {
      this.age = this.age + howMuch;
      return this.age;
    }

    public override string ToString()
    {
      return this.name + ", age " + this.age;
    }
  }
}


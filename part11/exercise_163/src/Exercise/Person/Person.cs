namespace Exercise
{
  using System;
  public class Person
  {

    public string name { get; }
    public int age { get; }

    public Person(string name, int age)
    {
      if (age < 0 || age > 120)
      {
        throw new ArgumentException("Wrong range for age!");
      }

      if (name == "" || name == null || name.Length > 40)
      {
        throw new ArgumentException("Name is empty or too long!");
      }
      this.name = name;
      this.age = age;
    }
  }
}
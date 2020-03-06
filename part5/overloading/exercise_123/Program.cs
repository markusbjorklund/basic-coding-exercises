using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter();
  
      counter.Increase();
      counter.Increase();
      counter.Increase();
      counter.Increase();
      counter.Increase();
      // should be five 
      Console.WriteLine(counter.value);
      counter.Increase(10);
      // should be fifteen
      Console.WriteLine(counter.value);
      counter.Decrease(2);
      counter.Decrease(2);
      counter.Decrease(1);
      //should be ten 
      Console.WriteLine(counter.value);
    }
  }
}

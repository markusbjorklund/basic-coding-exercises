using System;
using System.Collections.Generic;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(2);
        list.Add(1);
        PrintSmallerThan(list, 3);
        }
        public static void PrintSmallerThan(List<int> numbers, int threshold) 
{
  foreach(int number in numbers)
  {
    if (number < threshold) 
    {
      Console.WriteLine(number);
    }
  }
}

    }
}
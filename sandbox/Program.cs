using System;
using System.Collections.Generic;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);

for (int i - 1; i <= numbers.Count; i--)
    {
        int number = numbers[i];
        Console.WriteLine(number);
    }

//int index = numbers.Count - 1;
//while (index >= 0)
//{
//  int number = numbers[index];
//  Console.WriteLine(number);
//  index = index - 1;
//}
        
        }
    }
}
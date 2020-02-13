using System;
using System.Collections.Generic;

namespace exercise_110
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            // note to self, it's called Item.cs
            // worked with list named list but failed testing
            // list must be called itmes
            List<Item> items = new List<Item>();
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                // add names to the list
                items.Add(new Item(name));
            }
            // tidy up with an empty line
            Console.WriteLine();
            // show me the names and time
            foreach (Item name in items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace exercise_113
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!
            List<Book> books = new List<Book>();

            while (true)
            {
                // ask for title 
                Console.Write("Name: ");
                string title = Console.ReadLine();
                if (title == "")
                {
                    break;
                }
                // ask for amount of pages
                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());
                // ask for publication year
                Console.Write("Publication year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                // add bookinfo to list
                books.Add(new Book(title, pages, year));
            }

            // tidy up the print with a blank line
            Console.WriteLine();
            // what do you want to see?
            Console.Write("What information will be printed? ");
            string input = Console.ReadLine();
            // list the books, redid this part of the exercise
            // first attempt had too much code
            foreach (Book item in books)
            {
                if (input == "title")
                {
                    // just print the title
                    Console.WriteLine(item.title);
                }
                else if (input == "everything")
                {
                    // print everything
                    Console.WriteLine(item);
                }
                else 
                {
                  break;
                }
            }
        }
    }
}





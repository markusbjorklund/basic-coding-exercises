using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      string wildAnimals = "1 - Wolf \n2 - Tiger \n3 - Bear \n";
      string tameAnimals = "4 - Bird \n5 - Cat \n6 - Dog \n7 - Horse";
      string wildHunts = "M - Make sound \nH - Hunt";
      string tameEats = "E - Eat \nT - Talk to owner \nM - Make sound \nN - Give name";

      string question = "What do you want to do?";
      string initialOptions = "Q - Quit \nL - List all animals";

      Console.WriteLine(question);
      Console.WriteLine(initialOptions);

      while (true)
      {
        string navigation = Console.ReadLine();
        navigation.ToString();

        // quit on Q or q
        if (navigation == "Q" || navigation == "q")
        {
          break;
        }

        // list animals
        if (navigation == "L" || navigation == "l")
        {
          Console.WriteLine(wildAnimals + tameAnimals);
        }

        /* wolf */
        if (navigation == "1")
        {
          Wolf Wolf = new Wolf() )
          Console.WriteLine(question + "\n" + wildHunts);
        }
        /* Tiger */
        if (navigation == "2")
        {
          // you have chosen tiger
          Console.WriteLine(question + "\n" + wildHunts);
        }
        /* Bear */
        if (navigation == "3")
        {
          // you have chosen bear
          Bear Bear = new Bear();
          Console.WriteLine(question + "\n" + wildHunts);

        }

        /* Bird */
        if (navigation == "4")
        {
          Console.WriteLine(question + "\n" + tameEats);
        }
        /* Cat */
        if (navigation == "5")
        {
          Console.WriteLine(question + "\n" + tameEats);
        }
        /* Dog */
        if (navigation == "6")
        {
          Console.WriteLine(question + "\n" + tameEats);
        }
        /* Horse */
        if (navigation == "7")
        {
          Console.WriteLine(question + "\n" + tameEats);
        }
      }
    }
  }
}
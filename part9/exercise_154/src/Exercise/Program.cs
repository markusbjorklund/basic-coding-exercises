using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Organism organism = new Organism(20, 30);
      Console.WriteLine(organism);
      organism.Move(-10, 5);
      Console.WriteLine(organism);
      organism.Move(50, 20);
      Console.WriteLine(organism);

      Console.WriteLine();

      Herd herd = new Herd();
      herd.AddToHerd(new Organism(57, 66));
      herd.AddToHerd(new Organism(73, 56));
      herd.AddToHerd(new Organism(46, 52));
      herd.AddToHerd(new Organism(19, 107));
      Console.WriteLine(herd);
    }
  }
}
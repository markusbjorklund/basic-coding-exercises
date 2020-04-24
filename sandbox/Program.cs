using System;
using System.Collections.Generic;
public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("##############   DEBUG   ###############");

    Random rand = new Random();
    int temp = rand.Next(-30, 31);

    Console.WriteLine(temp);

  }
}
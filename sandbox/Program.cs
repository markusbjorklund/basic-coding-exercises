using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("##############   DEBUG   ###############");
    Console.WriteLine();

    string[] lines = File.ReadAllLines("words.txt");

    foreach (string line in lines)
    {

    string[] parts = line.Split(":"); // split the line based on the ':' character

    Console.WriteLine(parts[0]); // part of line before :
    Console.WriteLine(parts[1]); // part of line after :

    }

    // string[] parts = line.split(":"); // split the line based on the ':' character

    // Console.WriteLine(parts[0]); // part of line before :
    // Console.WriteLine(parts[1]); // part of line after :

    Console.WriteLine();
    Console.WriteLine("##############   DEBUG   ###############");

  }
}
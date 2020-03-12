using System;

namespace extra_08
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // printing stars in joulupukkis playground

      // PrintStars(5);
      // PrintStars(3);
      // PrintStars(9);

      // PrintSquare(4);

      // PrintRectangle(17, 3);

      // PrintTriangle(5);

      // PrintRightTriangle(5);

      ChristmasTree(22);
    }


    // print some stars
    public static void PrintStars(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    // print a square
    public static void PrintSquare(int size)
    {
      for (int i = 0; i < size; i++)
      {
        PrintStars(size);
      }
    }

    // print a rectangle
    public static void PrintRectangle(int width, int height)
    {
      for (int i = 0; i < height; i++)
      {
        PrintStars(width);
      }
    }

    // print a triangle
    public static void PrintTriangle(int size)
    {
      for (int i = 0; i <= size; i++)
      {
        PrintStars(i);
      }
    }


    public static void PrintSpaces(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write(" ");
      }
    }

    public static void PrintRightTriangle(int size)
    {
      for (int i = 0; i <= size; i++)
      {
        PrintSpaces(size - i);
        PrintStars(i);
      }
    }

    public static void ChristmasTree(int height)
    {
      for (int i = 0; i <= height; i++)
      {
        PrintSpaces(height - i);
        // print two triangles, move right triangle one character to the left to get one star at top
        PrintStars((2 * i) - 1);
      }
      // print the foot, min height for the tree is 3 = minwidth for tree is 5
      PrintSpaces(height - 2);
      PrintStars(3);
      PrintSpaces(height - 2);
      PrintStars(3);
    }
  }
}
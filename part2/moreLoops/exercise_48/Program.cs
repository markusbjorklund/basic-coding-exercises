using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers:");
        int sum = 0;
        int numbers = 0;

        int even = 0;
        int odd = 0;

        while (true) 
        {
          int input = Convert.ToInt32(Console.ReadLine());

        if (input == -1)  
        {
          break;
        }

        sum += input;
        numbers++;

        if ((input % 2) == 0) 
        {
          even++;
        }

        else 
        {
          odd++;
        }
      }
        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Numbers: " + numbers);
        Console.WriteLine("Average: " + (double)sum / numbers);
        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
      }
    }
}

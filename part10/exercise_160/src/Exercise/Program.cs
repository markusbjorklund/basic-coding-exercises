namespace Exercise
{
  using System.Collections.Generic;
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      // Card first = new Card(2, Suit.Diamond);
      // Card second = new Card(14, Suit.Spade);
      // Card third = new Card(12, Suit.Heart);

      // Console.WriteLine(first);
      // Console.WriteLine(second);
      // Console.WriteLine(third);

      // Console.WriteLine();

      // Card first = new Card(2, Suit.Club);
      // Card second = new Card(14, Suit.Spade);
      // Card third = new Card(12, Suit.Heart);
      // Card fourth = new Card(14, Suit.Heart);
      // Card fifth = new Card(12, Suit.Diamond);

      // List<Card> list = new List<Card> { first, second, third, fourth, fifth };
      // list.Sort();
      // list.ForEach(Console.WriteLine);

      // Hand hand = new Hand();

      // hand.Add(new Card(2, Suit.Diamond));
      // hand.Add(new Card(14, Suit.Spade));
      // hand.Add(new Card(12, Suit.Heart));
      // hand.Add(new Card(2, Suit.Spade));

      // hand.Print();

      // Hand hand = new Hand();

      // hand.Add(new Card(2, Suit.Diamond));
      // hand.Add(new Card(14, Suit.Spade));
      // hand.Add(new Card(12, Suit.Heart));
      // hand.Add(new Card(2, Suit.Spade));

      // hand.Sort();
      // hand.Print();

      Hand hand1 = new Hand();

      hand1.Add(new Card(2, Suit.Diamond));
      hand1.Add(new Card(14, Suit.Spade));
      hand1.Add(new Card(12, Suit.Heart));
      hand1.Add(new Card(2, Suit.Spade));

      Hand hand2 = new Hand();

      hand2.Add(new Card(11, Suit.Diamond));
      hand2.Add(new Card(11, Suit.Spade));
      hand2.Add(new Card(11, Suit.Heart));

      int comparison = hand1.CompareTo(hand2);

      if (comparison < 0)
      {
        Console.WriteLine("better hand is");
        hand2.Print();
      }
      else if (comparison > 0)
      {
        Console.WriteLine("better hand is");
        hand1.Print();
      }
      else
      {
        Console.WriteLine("hands are equal");
      }

    }
  }
}
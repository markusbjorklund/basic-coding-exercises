namespace Exercise
{
  using System.Collections.Generic;
  using System;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;

    // construct hand
    public Hand()
    {
      this.hand = new List<Card>();
    }

    // add cards to hand
    public void Add(Card card)
    {
      if (!this.hand.Contains(card))
        this.hand.Add(card);
    }

    // call the hand
    public void Print()
    {
      foreach (Card card in this.hand)
      {
        Console.WriteLine(card);
      }
    }

    public void Sort()
    {
      this.hand.Sort();
    }

    public int CompareTo(Hand hand)
    {
      // calculate values of cards in hand and compare them
      int cardValues = 0;
      foreach (Card card in this.hand)
      {
        cardValues += card.value;
      }

      int cardValuesCompared = 0;
      foreach (Card card in hand.hand)
      {
        cardValuesCompared += card.value;
      }
      return cardValues - cardValuesCompared;
    }
  }
}
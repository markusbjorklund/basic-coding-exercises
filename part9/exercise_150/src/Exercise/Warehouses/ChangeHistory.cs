namespace Exercise
{
  using System.Collections.Generic;
  using System;
  public class ChangeHistory
  {
    private List<int> history;

    public ChangeHistory()
    {
      this.history = new List<int>();
    }

    public void Add(int status)
    {
      this.history.Add(status);
    }

    public void Clear()
    {
      this.history.Clear();
    }

    // loop the list and get the largest value
    public int MaxValue()
    {
      // return 0 if empty
      if (this.history.Count == 0)
      {
        return 0;
      }

      // loop for largest value
      int largestValue = 0;
      foreach (var item in this.history)
      {
        if (item > largestValue)
        {
          largestValue = item;
        }
      }
      return largestValue;
    }

    public int MinValue()
    {
      // return 0 if empty
      if (this.history.Count == 0)
      {
        return 0;
      }

      // compare to largest value and count down from that
      int smallestValue = MaxValue();
      foreach (var item in this.history)
      {
        if (item < smallestValue)
        {
          smallestValue = item;
        }
      }
      return smallestValue;
    }

    // return the last number on the list
    public int LastValue()
    {
      int lastValue = 0;
      foreach (var item in this.history)
      {
        lastValue = item;
      }
      return lastValue;
    }

    public override string ToString()
    {
      return "Current: " + LastValue() + " Min: " + MinValue() + " Max: " + MaxValue();
    }
  }
}
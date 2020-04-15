using System;
using System.Collections.Generic;

namespace testing
{
  using System;
  using System.Collections.Generic;
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

    public int MaxValue()
    {
      int largestValue = 0;
      if (this.history.Count > 0)
      {
        largestValue = this.history.largestValue();
      } 
      return largestValue;
    }

    public int MinValue()
    {
      int smallestValue = 0;
      if (this.history.Count > 0)
      {
        smallestValue = this.history.smallestValue();
      }
      return smallestValue;
    }

    public override string ToString()
    {
      return "";
    }
  }
}

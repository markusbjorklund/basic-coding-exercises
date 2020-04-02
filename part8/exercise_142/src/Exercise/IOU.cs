using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
    private Dictionary<string, int> dictionary;

    // constructor public IOU() creates a new IOU
    public IOU()
    {
      this.dictionary = new Dictionary<string, int>();
    }

    // saves the amount owed and the person owed to to the IOU. You can use this to also lower the debt, but the total amount cannot be negative!
    public void ChangeDebt(string toWhom, int amount)
    {
      if (this.dictionary.ContainsKey(toWhom))
      {
        int newAmount = this.dictionary[toWhom] + amount;
        if (newAmount > 0)
        {
          this.dictionary[toWhom] = newAmount;
        }
        else
        {
          this.dictionary[toWhom] = 0;
        }
      }
      else if (amount > 0)
      {
        this.dictionary[toWhom] = amount;
      }
      else
      {
        this.dictionary[toWhom] = 0;
      }
    }

    // returns the amount owed to the person whose name is given as a parameter. If the person cannot be found, it returns 0.
    public int HowMuchDoIOweTo(string toWhom)
    {
      if (this.dictionary.ContainsKey(toWhom))
      {
        return this.dictionary[toWhom];
      }
      else
      {
        return 0;
      }
    }
  }
}
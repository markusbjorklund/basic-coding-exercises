using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
    private Dictionary<string, int> directory;

    // constructor public IOU() creates a new IOU
    public IOU()
    {
      this.directory = new Dictionary<string, int>();
    }

    // saves the amount owed and the person owed to to the IOU. You can use this to also lower the debt, but the total amount cannot be negative!
    public void ChangeDebt(string toWhom, int amount)
    {
      if (this.directory.ContainsKey(toWhom))
      {
        int newAmount = this.directory[toWhom] + amount;
        if (newAmount > 0)
        {
          this.directory[toWhom] = newAmount;
        }
        else
        {
          this.directory[toWhom] = 0;
        }
      }
      else if (amount > 0)
      {
        this.directory[toWhom] = amount;
      }
      else
      {
        this.directory[toWhom] = 0;
      }
    }

    // returns the amount owed to the person whose name is given as a parameter. If the person cannot be found, it returns 0.
    public int HowMuchDoIOweTo(string toWhom)
    {
      if (this.directory.ContainsKey(toWhom))
      {
        return this.directory[toWhom];
      }
      else
      {
        return 0;
      }
    }
  }
}
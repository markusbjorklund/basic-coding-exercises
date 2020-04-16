using System.Collections.Generic;

namespace Exercise
{
  public class OneItemBox : Box
  {
    private List<Item> list;
    public OneItemBox()
    {
      this.list = new List<Item>();
    }

    public override void Add(Item item)
    {
      if (this.list.Count == 0)
      {
        this.list.Add(item);
      }
    }

    public override bool IsInBox(Item item)
    {
      if (this.list.Contains(item))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
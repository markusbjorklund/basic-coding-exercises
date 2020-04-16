namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    private List<Item> list;
    private int capacity;
    public BoxWithMaxWeight(int capacity)
    {
      this.capacity = capacity;
      this.list = new List<Item>();
    }

    public override void Add(Item item)
    {
      // make sure not to add if the capacity is reached
      if (item.weight <= this.capacity)
      {
        int sumOfItems = 0;

        foreach (Item var in this.list)
        {
          sumOfItems = sumOfItems + item.weight;
        }
        if (sumOfItems + item.weight <= this.capacity)
        {
          list.Add(item);
        }
      }
    }

    public override bool IsInBox(Item item)
    {
      if (list.Contains(item))
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
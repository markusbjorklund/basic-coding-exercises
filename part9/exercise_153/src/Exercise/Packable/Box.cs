namespace Exercise
{
  using System.Collections.Generic;
  using System;
  public class Box : IPackable
  {
    private int boxedTotalWeight;
    private int capacity;
    private List<IPackable> itemsInBox;

    public Box(int capacity)
    { 
      this.capacity = capacity;
      this.boxedTotalWeight = 0;
      this.itemsInBox = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
      if (this.capacity - this.boxedTotalWeight >= item.Weight())
      {
      this.itemsInBox.Add(item);
      this.boxedTotalWeight += item.Weight();
      }
    }

    public int Weight()
    {
      int sumOfItemsWeight = 0;
      foreach (var item in itemsInBox)
      {
          sumOfItemsWeight += item.Weight();
      }
      return sumOfItemsWeight;
    }

    public override string ToString()
    {
      return itemsInBox.Count + " items, " + "total weight " + this.Weight() + " kg";
    }
  }
}
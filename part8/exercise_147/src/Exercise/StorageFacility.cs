using System;
using System.Collections.Generic;

namespace Exercise
{
  public class StorageFacility
  {

    private Dictionary<string, List<string>> myBigUnit;

    public StorageFacility()
    {
      this.myBigUnit = new Dictionary<string, List<string>>();
    }

    // adds the parameter item to the storage unit that is also given as a parameter
    public void Add(string unit, string item)
    {
      if (!this.myBigUnit.ContainsKey(unit))
      {
        this.myBigUnit.Add(unit, new List<string>());
      }
      this.myBigUnit[unit].Add(item);
    }

    // returns a list that contains all the items in the storage unit indicated by the parameter. If there is no such storage unit or it contains no items, the method should return an empty list
    public List<string> Contents(string storageUnit)
    {
      if (!this.myBigUnit.ContainsKey(storageUnit))
      {
        this.myBigUnit.Add(storageUnit, new List<string>());
      }
      {
        return this.myBigUnit[storageUnit];
      }
    }

    // removes the given item from the given storage unit
    public void Remove(string storageUnit, string item)
    {
      
      // remove item from unit
      this.myBigUnit[storageUnit].Remove(item);

      // if the unit is empty after removal, remove the unit
      if (this.myBigUnit[storageUnit].Count == 0)
      {
        this.myBigUnit.Remove(storageUnit);
      }
    }

    // returns the names of the storage units as a list
    public List<string> StorageUnits()
    {
      List<string> listUnits = new List<string>();
      Dictionary<string, List<string>>.KeyCollection keys = this.myBigUnit.Keys;
      foreach (string units in keys)
      {
        listUnits.Add(units);
      }
      return listUnits;
    }
  }
}
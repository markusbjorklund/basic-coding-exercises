using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {

    // adds the parameter item to the storage unit that is also given as a parameter
    public void Add(string unit, string item)
    {

    }

    // returns a list that contains all the items in the storage unit indicated by the parameter. If there is no such storage unit or it contains no items, the method should return an empty list
    public List<string> Contents(string storageUnit)
    {
      return new List<string>();
    }

    // removes the given item from the given storage unit
    public void Remove(string storageUnit, string item)
    {

    }

    // returns the names of the storage units as a list
    public List<string> StorageUnits()
    {
      return new List<string>();
    }
  }
}
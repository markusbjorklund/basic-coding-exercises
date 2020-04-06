using System;
using System.Collections.Generic;

namespace Exercise
{
  public class VehicleRegistry
  {
    private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();

    public bool Add(LicensePlate licensePlate, string owner)
    {
      if (!this.owners.ContainsKey(licensePlate))
      {
        this.owners.Add(licensePlate, owner);
        return true;
      }
      else
      {
        return false;
      }
    }

    public string Get(LicensePlate licensePlate)
    {
      if (this.owners.ContainsKey(licensePlate))
      {
        return this.owners[licensePlate];
      }
      else
      {
        return "No such plate found in registry!";
      }
    }

    public bool Remove(LicensePlate licensePlate)
    {
      if (this.owners.ContainsKey(licensePlate))
      {
        this.owners.Remove(licensePlate);
        return true;
      }
      else
      {
        return false;
      }
    }

    public void PrintLicensePlates()
    {
      foreach (KeyValuePair<LicensePlate, string> item in this.owners)
      {
        Console.WriteLine(item.Key);
      }
    }

    //HINT! In the printOwners method, you can create a list used for remembering the owners that were already printed. If an owner is not on the their name is printed and they are added to the list -- if an owner is on the list their name isn't printed.
    public void PrintOwners()
    {
      List<string> printedOwners = new List<string>();

      foreach (KeyValuePair<LicensePlate, string> item in this.owners)
      {
        if (!printedOwners.Contains(item.Value))
        {
          Console.WriteLine(item.Value);
        }
        printedOwners.Add(item.Value);
      }
    }
  }
}
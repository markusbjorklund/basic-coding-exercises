namespace Exercise
{
  using System.Collections.Generic;
  using System;
  public class Herd : IMovable
  {
    // They must be stored in e.g. a list data structure
    List<IMovable> herd;
    public Herd()
    {
      this.herd = new List<IMovable>();
    }

    public void AddToHerd(IMovable movable)
    {
      this.herd.Add(movable);
    }

    public void Move(int dx, int dy)
    {
      // Implements the Movable interface to the herd.
      foreach (IMovable movable in herd)
      {
        // Moves the herd with by the amount specified by the parameters. 
        movable.Move(dx, dy);
      }
    }

    public override string ToString()
    {
      // Returns a string representation of the positions of the members of the herd, each on its own line.
      string herdPosition = "";
      foreach (IMovable movable in herd)
      {
        herdPosition += movable.ToString() + "\n";
      }
      return herdPosition.ToString();
    }
  }
}
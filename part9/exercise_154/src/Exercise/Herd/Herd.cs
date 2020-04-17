namespace Exercise
{
  using System.Collections.Generic;
  using System;
  public class Herd : IMovable
  {
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
      foreach (IMovable movable in herd)
      {
        movable.Move(dx, dy);
      }
    }

    public override string ToString()
    {
      string herdPosition = "";
      foreach (IMovable movable in herd)
      {
        herdPosition += movable.ToString() + "\n";
      }
      return herdPosition;
    }
  }
}
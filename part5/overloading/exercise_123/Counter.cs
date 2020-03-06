namespace exercise_123
{
  public class Counter
  {
    public int value { get; set; }

    public Counter() : this(0)
    { }
    // set value of counter
    public Counter(int startValue)
    {
      this.value = startValue;
    }
    // increase by one
    public void Increase()
    {
      this.Increase(1);
    }
    // decrease by one
    public void Decrease()
    {
      this.Decrease(1);
    }
    // increase method
    public void Increase(int increaseBy)
    {
      if (increaseBy > 0)
      {
        this.value += increaseBy;
      }
    }
    // decrerase method
    public void Decrease(int decreaseBy)
    {
      if (decreaseBy > 0)
      {
        this.value -= decreaseBy;
      }
    }
  }
}
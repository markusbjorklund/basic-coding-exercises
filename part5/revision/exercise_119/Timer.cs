namespace exercise_119
{
  public class Timer
  {
    private ClockHand seconds;
    private ClockHand hundreths;

    public Timer()
    {
      this.seconds = new ClockHand(60);
      this.hundreths = new ClockHand(100);
    }
    public void Advance()
    {
      this.hundreths.Advance();
      if (this.hundreths.value == 0)
      {
        this.seconds.Advance();
      }
    }
    public override string ToString()
    {
      return seconds + ":" + hundreths;
    }
  }
}
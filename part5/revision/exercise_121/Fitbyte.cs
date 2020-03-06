namespace exercise_121 
{
  public class Fitbyte
  {
    private int age;
    private int restingHeartRate;
    private double maxHeartRate;
    public Fitbyte(int age, int restingHeartRate)
    {
      this.age = age;
      this.restingHeartRate = restingHeartRate;
    }
    public double TargetHeartRate(double percentageOfMaximum)
    {
      this.maxHeartRate = 206.3 - (0.711 * this.age);
      return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate;
    }
  }
}
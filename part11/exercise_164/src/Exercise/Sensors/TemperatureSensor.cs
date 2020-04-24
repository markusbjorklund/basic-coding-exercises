namespace Exercise
{
  using System;
  public class TemperatureSensor : Sensor
  {

    private Boolean sensorSwitch;

    public TemperatureSensor()
    {
      this.sensorSwitch = false;
    }

    public bool IsOn()
    {
      return this.sensorSwitch;
    }

    public void SetOn()
    {
      this.sensorSwitch = true;
    }

    public void SetOff()
    {
      this.sensorSwitch = false;
    }

    public int Read()
    {
      // if (sensorSwitch == false)
      if (!IsOn())
      {
        throw new InvalidOperationException("Turn on the Sensor, Sensei!");
      }
      Random rand = new Random();
      int temp = rand.Next((61) - 30);
      return temp;
    }
  }
}
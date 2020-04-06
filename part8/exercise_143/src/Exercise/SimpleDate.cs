namespace Exercise
{
  public class SimpleDate
  {
    private int day;
    private int month;
    private int year;

    public SimpleDate(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public override string ToString()
    {
      return this.day + "." + this.month + "." + this.year;
    }

    public bool Earlier(SimpleDate compared)
    {
      if (this.year < compared.year)
      {
        return true;
      }
      if (this.year == compared.year && this.month < compared.month)
      {
        return true;
      }
      if (this.year == compared.year && this.month == compared.month &&
        this.day < compared.day)
      {
        return true;
      }
      return false;
    }

    public override bool Equals(object compared)
    {
      // DO SOMETHING HERE
      // return true if both values are the same
      if (this == compared)
      {
        return true;
      }

      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      // do some copy paste from the reading material
      else
      {
        SimpleDate comparedSimpleDate = (SimpleDate)compared;

        // if the values of the object variables are equal, the objects are, too
        return this.day == comparedSimpleDate.day && this.month == comparedSimpleDate.month && this.year == comparedSimpleDate.year;
      }
    }

    public override int GetHashCode()
    {
      // DO SOMETHING HERE
      return this.day.GetHashCode();
    }
  }
}
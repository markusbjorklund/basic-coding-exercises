namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
      Money newMoney = new Money(this.euros, this.cents);
      // create a new Money object that has the correct worth
      // return the new Money object
      newMoney.euros += addition.euros;
      newMoney.cents += addition.cents;

      if (newMoney.cents > 99)
      {
        newMoney.euros = newMoney.euros + newMoney.cents / 100;
        newMoney.cents = newMoney.cents % 100;
      }
      return newMoney;
    }

    public Money Minus(Money decreaser)
    {
      Money newMoney = new Money(this.euros, this.cents);
      // create a new Money object that has the correct worth
      newMoney.euros -= decreaser.euros;
      newMoney.cents -= decreaser.cents;

      if (newMoney.cents < 0)
      {
        newMoney.euros = newMoney.euros - 1;
        newMoney.cents = newMoney.cents + 100;
      }
      else if (newMoney.euros < 0 || newMoney.cents < 0)
      {
        newMoney.euros = 0;
        newMoney.cents = 0;
      }
      // return the new Money object
      return newMoney;
    }

    public bool LessThan(Money compared)
    {
      // Do something here
      if (this.euros < compared.euros)
      {
        return true;
      }
      else if (this.euros == compared.euros && compared.cents > this.cents)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public override string ToString()
    {
      string zero = "";
      if (cents < 10)
      {
        zero = "0";
      }
      return euros + "." + zero + cents + "e";
    }
  }
}

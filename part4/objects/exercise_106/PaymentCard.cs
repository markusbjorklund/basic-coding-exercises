namespace exercise_106
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
      this.balance = openingBalance - this.balance;
    }

    public override string ToString()
    {
      // write code here
      return "The card has a balance of " + this.balance + " euros";
    }
  }
}
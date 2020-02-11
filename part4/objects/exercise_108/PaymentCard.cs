namespace exercise_108
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance - this.balance;
        }

        // namnamnnamnam
        public void EatLunch()
        {
            double lunch = 10.60;
            this.balance = this.balance - lunch;
        }

        // engage insomnia
        public void DrinkCoffee()
        {
            double coffe = 2.0;
            this.balance = this.balance - coffe;
        }

        // money, money, give me money
        public void AddMoney(double amount)
        {
            // write code here
            this.balance = this.balance + amount;

        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}
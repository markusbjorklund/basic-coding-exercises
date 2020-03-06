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
            if (this.balance > lunch)
            {
                this.balance = this.balance - lunch;
            }
        }

        // engage insomnia
        public void DrinkCoffee()
        {
            double coffe = 2.0;
            if (this.balance > coffe)
            {
                this.balance = this.balance - coffe;
            }
        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}
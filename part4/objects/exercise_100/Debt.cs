using System;

namespace exercise_100
{
    public class Debt
    {
        private double balance;
        private double interestRate;
        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }
        public void PrintBalance()
        {
            // show me the money
            Console.WriteLine(this.balance);

        }
        public void WaitOneYear()
        {
            // show me less money
            this.balance = this.balance * this.interestRate;
        }
    }
}


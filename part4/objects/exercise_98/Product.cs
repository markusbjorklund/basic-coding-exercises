using System;

namespace exercise_98
{
    public class Product
    {
        private string name;
        private double price;
        private int quantity;
        public Product(string name, double price, int quantity)
        {
            this.price = price;
            this.quantity = quantity;
            this.name = name;
        }

        public void PrintProduct()
        {
            Console.WriteLine(name + ": price " + price + ": " + quantity + " pcs");
        }
    }
}
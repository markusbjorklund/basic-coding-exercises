using System;

namespace exercise_104
{
    public class Multiplier
    {
        public int value { get; set; }

        public Multiplier(int value)
        {
            this.value = value;
        }

        public int Multiply(int value)
        {
            return this.value = this.value * value;
        }
    }
}

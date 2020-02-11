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
            this.value = this.value * value;
            return this.value;
        }
    }
}

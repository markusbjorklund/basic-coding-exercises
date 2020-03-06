using System;

namespace exercise_102
{
    public class Gauge
    {
        public int value { get; set; }
        public Gauge()
        {
            this.value = 0;
        }
        public void Increase()
        {
            // give me gasoline
            if (this.value < 5)
            {
                this.value++;
            }
        }
        // say no to drowning in gasoline
        public void Decrease()
        {
            if (this.value > 1)
            {
                this.value--;
            }
        }
        // drowning in gasoline
        public bool Full()
        {
            return this.value == 5;
        }
    }
}

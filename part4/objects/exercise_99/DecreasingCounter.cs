using System;

namespace exercise_99
{
    public class DecreasingCounter
    {
        private int value;   // a variable that remembers the value of the counter

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            // write the method implementation here
            // the aim is to decrement the value of the counter by one
            // less is more
            this.value = this.value - 1;
            if (this.value <= 0)
            {
              this.value = 0;
            }
        }

        public void Reset()
        {
            // write the method implementation here
            this.value = 0;
        }
    }
}


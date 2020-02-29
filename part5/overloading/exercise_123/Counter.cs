using System;
namespace exercise_123
{
    public class Counter
    {
        private int startValue;
        
        public Counter()
        {
            this.startValue=0;
            this.value=startValue;
        }
        public Counter(int startValue)
        {
            this.startValue = startValue;
            this.value = startValue;
        }
        public int value { get; set; }
        public void Increase()
        {
            value=startValue+1;
        }
        public void Decrease()
        {
            value=startValue-1;
        }
        public void Increase(int increaseBy)
        {
            if (increaseBy>=0)
            {
                value = value + increaseBy;
            }
            else
            {
                value = value;
            }
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy>=0)
            {
                value = value - decreaseBy;
            }
            else
            {
                value = value;
            }
        }

    }



}
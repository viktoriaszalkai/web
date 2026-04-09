using System;

namespace Base01
{
    public class Dispenser
    {
        private double max;
        private double dose;
        private double currentAmount;

        public Dispenser(double max, double dose)
        {
            this.max = max;
            this.dose = dose;
            this.currentAmount = 0.0;
        }
        public bool Empty()
        {
            return currentAmount <= 0.0;
        }
        public void Fill()
        {
            currentAmount = max;
        }
        public void Push()
        {
            if (currentAmount >= dose)
            {
                currentAmount -= dose;
            }
            else
            {
                currentAmount = 0.0;
            }
        }
    }
}
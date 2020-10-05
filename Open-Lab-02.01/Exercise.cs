using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] numbers = { 1.2, 2.6, 3.5, 4.5, 5.6 };
            return numbers;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}

using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;

                double denominator = 2;
                if (Math.Abs(denominator) < double.Epsilon)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double term1 = Math.Cos(x);
                    double term2 = (4 * x) / denominator;
                    double term3 = Math.Sin(x) * 3 * x;

                    valueArray[i] = Math.Round(term1 + term2 - term3, 2);
                }
            }

            return valueArray;
        }
    }
}

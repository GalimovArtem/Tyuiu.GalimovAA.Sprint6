using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                double x = startValue + i;
                double denominator = Math.Sin(x) - 3 + x;

                
                if (Math.Abs(denominator) < double.Epsilon)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double result = (3 * x - 1.5) / denominator + 2;

                
                    if (double.IsNaN(result) || double.IsInfinity(result))
                    {
                        valueArray[i] = 0;
                    }
                    else
                    {
                        valueArray[i] = Math.Round(result, 2);
                    }
                }
            }

            return valueArray;
        }
    }
}
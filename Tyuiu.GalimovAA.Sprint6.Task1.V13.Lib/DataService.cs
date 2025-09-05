using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task1.V13.Lib
{
    public class DataService : ISprint6Task1V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            double x;
            int count = 0;

            for (x = startValue; x <= stopValue; x++)
            {
               
                if (4 * x - 0.5 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = Math.Round((3 * Math.Cos(x)) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
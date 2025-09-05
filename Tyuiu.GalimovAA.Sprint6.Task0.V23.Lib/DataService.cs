using System;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.GalimovAA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double result = Math.Log((x + 1.0) / (x + 2.0));
            return Math.Round(result, 3);
        }
    }
}
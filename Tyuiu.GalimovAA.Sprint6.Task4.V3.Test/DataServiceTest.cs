using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalimovAA.Sprint6.Task4.V3.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 1.96, 1.76, 1.14, 1.31, 1.84, 1.8, 1.84, 1.91, 1.14, -0.74, -0.96 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();
            int startValue = 0;
            int stopValue = 0;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(0, res[0]);
        }
    }
}
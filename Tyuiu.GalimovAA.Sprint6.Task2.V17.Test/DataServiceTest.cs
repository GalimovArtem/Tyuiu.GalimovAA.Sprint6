using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint6.Task2.V17.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task2.V17.Test
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
            double[] wait = {
                13.58, 8.78, 3.72, -1.4, -6.42,
                -10.0, -11.58, -9.72, -2.78, 10.42,
                32.58
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
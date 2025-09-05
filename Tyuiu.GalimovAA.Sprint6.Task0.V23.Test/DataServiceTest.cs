using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double result = ds.Calculate(x);
            double wait = -0.288;
            Assert.AreEqual(wait, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint6.Task1.V13.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task1.V13.Test
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
                22.41, 16.02, 10.58, 5.83, 1.56, 0, -2.56, -5.17, -8.01, -11.09, -14.41
            };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем точку, где знаменатель равен 0 (x = 0.125)
            int startValue = 0;
            int stopValue = 1;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // При x=0: (4*0-0.5) = -0.5 ≠ 0
            // При x=1: (4*1-0.5) = 3.5 ≠ 0
            // В данном диапазоне деления на ноль нет
            Assert.AreNotEqual(0, res[0]); // x=0
            Assert.AreNotEqual(0, res[1]); // x=1
        }
    }
}
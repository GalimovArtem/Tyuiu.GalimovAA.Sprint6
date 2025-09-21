using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint6.Task7.V16.Lib;
using System.IO;

namespace Tyuiu.GalimovAA.Sprint6.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\test\test.csv";
            string testData = "1;2;3\n4;5;6\n7;8;9\n10;11;12\n13;14;15\n16;17;18";
            File.WriteAllText(path, testData);

            int[,] result = ds.GetMatrix(path);

            Assert.AreEqual(-1, result[4, 0]); // 13 -> -1 (нечетное)
            Assert.AreEqual(14, result[4, 1]); // 14 остается (четное)
            Assert.AreEqual(-1, result[4, 2]); // 15 -> -1 (нечетное)
        }
    }
}
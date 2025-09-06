using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalimovAA.Sprint6.Task5.V11.Lib;
using System.IO;

namespace Tyuiu.GalimovAA.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\artem\source\repos\Tyuiu.GalimovAA.Sprint6\Tyuiu.GalimovAA.Sprint6.Task5.V11\bin\Debug\InPutFileTask5V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);

            double[] wait = { 5.0, 10.0, 15.0, 20.0 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
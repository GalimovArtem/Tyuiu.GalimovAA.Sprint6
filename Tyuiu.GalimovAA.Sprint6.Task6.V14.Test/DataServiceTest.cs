using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib;
using System.IO;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Test\InPutFileTask6V14.txt";

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            string wait = "zoo amazing puzzle zombie";
            Assert.AreEqual(wait, result);
        }
    }
}
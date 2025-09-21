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

            File.WriteAllText(path, "Hello world\nThis is a test with zoo and amazing words\nFinal zzz line");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            string expected = "zoo amazing zzz";
            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidCollectTextFromFileNoZ()
        {
            string path = @"C:\Test\InPutFileTask6V14_NoZ.txt";

            File.WriteAllText(path, "Hello world\nThis is a test without special letters\nFinal line");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("", result);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidCollectTextFromFileMixedCase()
        {
            string path = @"C:\Test\InPutFileTask6V14_Mixed.txt";

            File.WriteAllText(path, "Zoo amazing ZEBRA fizz Buzz");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            string expected = "Zoo amazing ZEBRA fizz Buzz";
            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}
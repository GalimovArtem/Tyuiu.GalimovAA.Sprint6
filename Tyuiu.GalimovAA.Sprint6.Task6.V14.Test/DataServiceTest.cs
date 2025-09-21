using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Test\InPutFileTask6V14.txt";

            File.WriteAllText(path, "hello world\nzebra amazing\ntest zoo\nfinal");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("zebra amazing zoo", result);

            File.Delete(path);
        }
    }
}
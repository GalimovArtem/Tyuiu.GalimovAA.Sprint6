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

            string testData = "Hello world\nThis is test\nzebra amazing\nquick brown fox\nlazy dog";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("z", path);

            string wait = "zebra lazy";
            Assert.AreEqual(wait, result);
        }
    }
}
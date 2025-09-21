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

            string testContent = "Hello world\nThis is a test\nzebra amazing\nquick brown fox\nlazy dog";
            File.WriteAllText(path, testContent);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("", path);
            string wait = "zebra lazy";

            Assert.AreEqual(wait, result);

            File.Delete(path);
        }

        [TestMethod]
        public void FileNotExistsTest()
        {
            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("", @"C:\NonexistentFile.txt");
            string wait = "Файл не существует";

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void NoZWordsTest()
        {
            string path = @"C:\Test\NoZFile.txt";
            File.WriteAllText(path, "Hello world\nThis is a test\nquick brown fox");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("", path);
            string wait = "";

            Assert.AreEqual(wait, result);

            File.Delete(path);
        }
    }
}
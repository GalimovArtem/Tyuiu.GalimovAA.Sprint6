using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string path = @"C:\temp\InPutFileTask5V11.txt";

            string testData = "12 23.13 13 13 4 -3 13 -11.33 -13 25 23 63 -17";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            double[] wait = { 12.0, 23.13, 13.0, 13.0, 4.0, 13.0, 25.0, 23.0, 63.0 };

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidLoadFromDataFileWithMultipleLines()
        {
            string path = @"C:\temp\InPutFileTask5V11_2.txt";

            string testData = "12 23.13 13\n13 4 -3\n13 -11.33 -13\n25 23 63 -17";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            double[] wait = { 12.0, 23.13, 13.0, 13.0, 4.0, 13.0, 25.0, 23.0, 63.0 };

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InvalidFileFormatTest()
        {
            string path = @"C:\temp\InvalidFile.txt";

            string testData = "12 abc 13 4.5";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint6.Task5.V11.Lib;
using System.IO;

namespace Tyuiu.GalimovAA.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile_Kratnie5()
        {
            string path = @"C:\temp\InPutFileTask5V11.txt";

            string testData = "13.0 11.49 3.36 10.0 14.52 16.0 13.66 0.48 4.13 19.0 11.0 11.28";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            double[] wait = { 10.0 }; 

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidLoadFromDataFile_MultipleOf5()
        {
            string path = @"C:\temp\InPutFileTask5V11_2.txt";

            string testData = "5.0 10.0 15.0 3.14 7.5 20.0 25.5 30.0";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            double[] wait = { 5.0, 10.0, 15.0, 20.0, 30.0 };

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidLoadFromDataFile_WithNegative()
        {
            string path = @"C:\temp\InPutFileTask5V11_3.txt";

            string testData = "-5.0 10.0 -15.0 3.14 7.5 20.0 -25.5 30.0";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            double[] wait = { 10.0, 20.0, 30.0 }; 

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
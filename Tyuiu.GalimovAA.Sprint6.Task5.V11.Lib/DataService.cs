using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task5.V11.Lib
{
    public class DataService : ISprint6Task5V11
    {
        public double[] LoadFromDataFile(string path)
        {
            try
            {
                string fileContent = File.ReadAllText(path);

     
                string[] numberStrings = fileContent.Split(new[] { ' ', '\t', '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);

                var positiveValues = numberStrings
                    .Select(str => double.Parse(str.Trim()))
                    .Where(value => value > 0)
                    .ToArray();


                for (int i = 0; i < positiveValues.Length; i++)
                {
                    positiveValues[i] = Math.Round(positiveValues[i], 3);
                }

                return positiveValues;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}
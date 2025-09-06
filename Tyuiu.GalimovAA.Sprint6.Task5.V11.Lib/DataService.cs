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
                string[] lines = File.ReadAllLines(path);

                var result = lines
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(line => double.Parse(line.Replace('.', ',')))
                    .Where(num => num % 5 == 0)
                    .Select(num => Math.Round(num, 3))
                    .ToArray();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}
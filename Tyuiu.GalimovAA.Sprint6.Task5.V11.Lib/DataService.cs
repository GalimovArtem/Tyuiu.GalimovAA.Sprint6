using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
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
                List<double> resultValues = new List<double>();

                string[] numberStrings = fileContent.Split(new[] { ' ', '\t', '\n', '\r', ',', ';' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string numberStr in numberStrings)
                {
                    if (double.TryParse(numberStr.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {

                        if (number > 0 && (Math.Abs(number % 5) < 0.001))
                        {
                            resultValues.Add(Math.Round(number, 3));
                        }
                    }
                }

                return resultValues.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}
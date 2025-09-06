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

                string currentNumber = "";
                bool inNumber = false;

                foreach (char c in fileContent)
                {
                    if (char.IsDigit(c) || c == '-' || c == '.')
                    {
                        currentNumber += c;
                        inNumber = true;
                    }
                    else if (inNumber)
                    {
                      
                        ProcessNumber(currentNumber, resultValues);
                        currentNumber = "";
                        inNumber = false;
                    }
                }

                if (inNumber)
                {
                    ProcessNumber(currentNumber, resultValues);
                }

                for (int i = 0; i < resultValues.Count; i++)
                {
                    resultValues[i] = Math.Round(resultValues[i], 3);
                }

                return resultValues.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }

        private void ProcessNumber(string numberStr, List<double> resultValues)
        {
            if (!string.IsNullOrWhiteSpace(numberStr))
            {
                if (double.TryParse(numberStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {

                    if (Math.Abs(number % 5) < 0.001 || Math.Abs(number % 5 - 5) < 0.001)
                    {
                        resultValues.Add(number);
                    }
                }
            }
        }
    }
}
using System;
using System.Linq;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string str, string path)
        {
            StringBuilder result = new StringBuilder();

            if (!File.Exists(path))
            {
                return "Файл не существует";
            }

            try
            {
                string[] lines = File.ReadAllLines(path);
                char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' };

                foreach (string line in lines)
                {
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.IndexOf('z', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }

                if (result.Length > 0)
                {
                    result.Length--; // Убираем последний пробел
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                return $"Ошибка при чтении файла: {ex.Message}";
            }
        }
    }
}
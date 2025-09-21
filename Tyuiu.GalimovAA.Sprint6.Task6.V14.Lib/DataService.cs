using System;
using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string str, string path)
        {
            StringBuilder result = new StringBuilder();

            try
            {
                if (!File.Exists(path))
                    return "Файл не существует";

                string[] lines = File.ReadAllLines(path);
                char[] separators = GetWordSeparators();

                foreach (string line in lines)
                {
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (ContainsZ(word))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }

                return result.Length > 0 ? result.ToString().Trim() : "Слова с буквой 'z' не найдены";
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }

        private char[] GetWordSeparators()
        {
            return new char[] {
                ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r',
                '-', '_', '(', ')', '[', ']', '{', '}', '"', '\''
            };
        }

        private bool ContainsZ(string word)
        {
            return word.IndexOf('z', StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
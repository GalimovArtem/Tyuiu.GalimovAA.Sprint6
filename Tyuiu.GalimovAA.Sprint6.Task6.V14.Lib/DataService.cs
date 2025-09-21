using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            string content = File.ReadAllText(path);

            // Разделяем текст на слова, используя различные разделители
            char[] separators = new char[] { ' ', '\r', '\n', '\t', '.', ',', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '"', '\'' };

            string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Фильтруем слова, содержащие только строчную букву 'z'
            var wordsWithZ = words.Where(word => word.IndexOf('z') >= 0);

            // Объединяем слова через пробел
            return string.Join(" ", wordsWithZ);
        }
    }
}
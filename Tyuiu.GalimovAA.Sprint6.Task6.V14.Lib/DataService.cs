using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.Linq;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);

                    foreach (string line in lines)
                    {
                        string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' },
                                                   StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            if (word.Contains('z') || word.Contains('Z'))
                            {
                                result += word + " ";
                            }
                        }
                    }

                    // Убираем последний пробел
                    if (result.Length > 0)
                    {
                        result = result.Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                result = "Ошибка: " + ex.Message;
            }

            return result;
        }

        public string CollectTextFromFile(string str, string path)
        {
            throw new NotImplementedException();
        }
    }
}
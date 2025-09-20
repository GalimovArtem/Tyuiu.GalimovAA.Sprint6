using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string str, string path)
        {
            string[] lines = File.ReadAllLines(path);
            var resultWords = new System.Collections.Generic.List<string>();

            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '\t' },
                                          StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.IndexOf('z', StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        resultWords.Add(word);
                    }
                }
            }

            return string.Join(" ", resultWords);
        }
    }
}
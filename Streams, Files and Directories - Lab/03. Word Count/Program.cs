namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\words.txt";
            string textPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> words = new();
            StreamReader reader = new(wordsFilePath);
            StreamReader text = new(textFilePath);
            StreamWriter writer = new (outputFilePath);
            var wordsSorted = words.OrderByDescending(x => x.Value);
            using (reader)
            {
                var line = reader.ReadLine().ToLower();
                while (line != null)
                {
                    var wordsArray = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in wordsArray)
                    {
                        if (!words.ContainsKey(item))
                        {
                            words.Add(item, 0);
                        }
                        else
                        {
                            words[item]++;
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            using (text)
            {
                var line = text.ReadLine().ToLower();
                var regex = new Regex(@"\b([a-z]{1,})\b");
                while (line != null)
                {
                    var wordsArray = Regex.Split(line, @"\b([a-z]{1,})\b");
                    foreach (var item in wordsArray)
                    {
                        if (words.ContainsKey(item))
                        {
                            words[item]++;
                        }
                    }
                    line = text.ReadLine();
                }
            }
            foreach (var item in wordsSorted)
            {
                writer.WriteLine($"{item.Key} - {item.Value}");
                writer.Flush();
            }

        }
    }
}
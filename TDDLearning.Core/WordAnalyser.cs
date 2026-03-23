using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TDDLearning.Core
{
    public class WordAnalyser
    {
        public List<string> FindLongestWords(string text)
        {
            List<string> longestWords = new List<string>();
            if (string.IsNullOrWhiteSpace(text)) return longestWords;

            string cleanText = Regex.Replace(text, @"[^\w\s]", "");
            string[] words = cleanText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words) 
            {
                if (word.Length > count) 
                { 
                    count = word.Length;
                    longestWords.Clear();
                    longestWords.Add(word); 
                }
                else if (word.Length == count) { longestWords.Add(word); }
            }
            return longestWords;
        }

        public Dictionary<char, int> CalculateLetterFrequency(string text)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            if (string.IsNullOrWhiteSpace(text)) return charFrequency;

            string cleanText = text.ToLower();

            foreach (char c in cleanText)
            {
                if (char.IsLetter(c))
                {
                    if (charFrequency.ContainsKey(c))
                    {
                        charFrequency[c]++;
                    }
                    else
                    {
                        charFrequency.Add(c, 1);
                    }
                }
            }
            return charFrequency;
        }
    }
}

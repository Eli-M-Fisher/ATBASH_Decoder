using System;
using System.Collections.Generic;

namespace ATBASH_Decoder
{
    public static class WordFinder
    {
        public static List<string> Find(string input)
        {
            List<string> indicators = new List<string>() { "bomb", "nukhba", "fighter", "rocket", "secret" };
            string[] inputItems = input.Split(" ");
            List<string> compiledIndicators = new List<string>();

            foreach (var word in inputItems)
            {
                foreach (var warning in indicators)
                {
                    if (warning.Contains(word))
                    {
                        compiledIndicators.Add(word);
                    }
                }
            }
            return compiledIndicators;
        }
    }
}
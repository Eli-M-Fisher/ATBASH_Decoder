

using System;
using System.Collections.Generic;

namespace ATBASH_Decoder
{
    public static class WordCounter
    {
        public static string Analyze(string cleanText, List<string> foundWords)
        {
            int score = foundWords.Count;
            string severity = GetSeverity(score);

            string finalMessage = $"Decrypted message:\n{cleanText}\n\n" +
                                  $"Threat Level: {severity} ({score} suspicious words found)";
            return finalMessage;
        }

        private static string GetSeverity(int score)
        {
            if (score >= 1 && score <= 5)
                return "WARNING";
            else if (score >= 6 && score <= 10)
                return "DANGER!";
            else if (score >= 11 && score <= 15)
                return "ULTRA ALERT!";
            else
                return "No Threat Detected";
        }
    }
}
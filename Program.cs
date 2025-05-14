using System;
using System.Collections.Generic;

namespace ATBASH_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ATBASH Decoder System ===");

            // Simulated output from Decryption and CleanText
            string cleanText = "the bomb will explode in the secret location";

            // Simulated result from WordFinder
            List<string> foundWords = new List<string> { "bomb", "secret" };

            // Analyze the message using WordCounter
            string finalMessage = WordCounter.Analyze(cleanText, foundWords);

            // Print the final message
            Console.WriteLine("\n" + finalMessage);
        }
    }
}

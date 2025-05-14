using System;
using System.Collections.Generic;

namespace ATBASH_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ATBASH Decoder System ===");

            // Step 1: simulated Input
            string encryptedMessage = "Gsv xlwv gl zokszyvg ziv ulc...";

            // Step 2: simulated Decryption
            string decryptedMessage = "the bomb will explode in the secret location";

            // Step 3: Clean the text simulated
            string cleanText = decryptedMessage.ToLower(); // assume we clean and normalize case

            // Step 4: simulated Find suspicious words
            List<string> foundWords = WordFinder.Find(cleanText);

            // Step 5: Analyze threat level
            string finalMessage = WordCounter.Analyze(cleanText, foundWords);

            // Step 6: Print the result
            Console.WriteLine("\n" + finalMessage);
        }
    }
}

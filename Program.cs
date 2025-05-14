using System;

namespace ATBASH_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ATBASH Decoder System ===");

            // Example encrypted message for initial testing
            string encryptedMessage = "Gsv xlwv gl zokszyvg ziv ulc...";

            // Future integration with team modules:
            // string decrypted = Decryption.Decrypt(encryptedMessage);
            // string cleanText = CleanText.Clean(decrypted);
            // List<string> foundWords = WordFinder.Find(cleanText, Constants.SuspiciousWords);
            // string finalMessage = WordCounter.Analyze(cleanText, foundWords);

            // Console.WriteLine(finalMessage);
        }
    }
}

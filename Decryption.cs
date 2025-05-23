using System;
using System.Collections.Generic;

namespace ATBASH_Decoder
{
    public static class Decryption
    {
        public static string decryption(string str)
        {
            Dictionary<char, char> Dict = new Dictionary<char, char>();
            string newStr = "";
            string abcd = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < abcd.Length; i++)
            {
                Dict.Add(abcd[i], abcd[abcd.Length - 1 - i]);
            }

            foreach (char letter in str)
            {
                if (Dict.ContainsKey(Char.ToLower(letter)))
                {
                    char mapped = Dict[Char.ToLower(letter)];
                    newStr += Char.IsUpper(letter) ? Char.ToUpper(mapped) : mapped;
                }
                else
                {
                    newStr += letter;
                }
            }

            return newStr;
        }
    }
}
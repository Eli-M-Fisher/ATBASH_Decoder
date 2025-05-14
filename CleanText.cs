using System;
using System.Collections.Generic;

namespace ATBASH_Decoder
{
    
    public static class CleanText
    {
    public static string Clean(string input)
{
	string clearedText = "";
	for (int i = 0; i < input.Length; i++)
	{
		if (!char.IsPunctuation(input, i)) clearedText += Convert.ToString(input[i]) ;
	}
    
    return clearedText;
}
    }
}
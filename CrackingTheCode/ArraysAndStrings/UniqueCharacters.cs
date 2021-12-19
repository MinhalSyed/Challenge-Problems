using System;
using System.Linq;


/*
    Return if string has unique characters without any additional data structures.
    Assume all lower case and only chars a-z;
*/
public class Program
{
    public static void Main()
    {
        HasUniqueCharacters("hello").Dump();
		HasUniqueCharacters("cat").Dump();
		HasUniqueCharacters("cdog").Dump();
		HasUniqueCharacters("tcat").Dump();
		HasUniqueCharacters("aquickfoxjumps").Dump();
		HasUniqueCharacters("acfijkmopqsux").Dump();
    }

    public static bool HasUniqueChars(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        if(input.Length > 26)
        {
            return false;
        }

        int charMask = 0;

        for(int i = 0; i < input.Length; i++)
        {
            int bitsToShift = (int) input[i] - (int) 'a';
            
            if((charMask & (1 << bitsToShift)) != 0)
            {
                return false;
            }

            charMask |= 1 << bitsToShift;
        }

        return true;
    }
}
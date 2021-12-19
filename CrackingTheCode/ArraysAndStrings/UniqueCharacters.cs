using System;
using System.Collections.Generic;
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

    public static bool HasUniqueCharacters(string input)
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

    public static bool HasUniqueCharacters2(string input)
    {
        var charsHashSet = new HashSet<char>();

        if(string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        for(int i =0; i < input.Length; i++)
        {
            if(charsHashSet.Contains(input[i]))
            {
                return false;
            }

            charsHashSet.Add(input[i]);
        }

        return true;
    }
}
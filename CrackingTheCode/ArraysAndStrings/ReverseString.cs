using System;
using System.Linq;

public class Program
{
    public static void Main()
    {

    }

    public static string Reverse(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return input;
        }
        
        /* Impossible to do in C# without new memory allocation. */
        var inputArry = input.ToCharArray();

        int start = 0;
        int end = inputArry.Length - 1;

        while(start < end)
        {
            var temp = inputArry[end];
            inputArry[end] = inputArry[start];
            inputArry[start] = temp;
            start++;
            end--;
        }

        return new string(inputArry);
    }
}
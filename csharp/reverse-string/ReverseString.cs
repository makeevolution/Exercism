using System;
using System.Linq;
using System.Collections.Generic;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        // Since Reverse function returns an ienumerable of chars,
        // change it to an array of chars, and finally use constructor
        // method to change the char array to a string
        return new string(input.Reverse().ToArray());
    }
    public static void Main()
    {
        System.Console.WriteLine("abc".Reverse().ToArray());
    }
}
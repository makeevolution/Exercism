using System;
using System.Linq;

public static class ResistorColor
{
    private static string[] colors = {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Grey", "White"};

    /* => is lambda expression! */
    public static int ColorCode(string color) => Array.IndexOf(colors.Select(x => x.ToLower()).ToArray(), color.ToLower());

    public static string[] Colors() => colors.Select(x => x.ToLower()).ToArray();
    
}
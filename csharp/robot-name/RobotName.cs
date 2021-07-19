using System;
using System.Security.Cryptography;
using System.Linq;

public class Robot
{
    /* since not using auto-property for getter setter, need a backing field: */
    private string name = GetRandomName();
    
    /* create an instance of the random class */
    private static Random random = new Random();
    public string Name
    {
        get
        {
            /* For each of the string(...) in name, what happens is we first create an enumerable of A-Z (or 0-9), then
            for each enumerable, select a random element from it; this returns a random enumerable of letters. Finally, join the letters using Toarray
            and change it to string using string().*/ 
            return name;
        }
    }

    public void Reset()
    {
        this.name = GetRandomName();
    }

    public static string GetRandomName()
    {
       return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ",2).Select(s => s[random.Next(s.Length)]).ToArray()) + 
            new string(Enumerable.Repeat("0123456789",3).Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
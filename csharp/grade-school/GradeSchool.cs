using System;
using System.Collections.Generic;

public class GradeSchool
{
    public string[] roster = {};
    public int[] grade  = {};
    public void Add(string student, int grade)
    {
        Array.Sort(roster, )
    }

    public IEnumerable<string> Roster()
    {
        return roster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    void Main()
    {
        System.Console.WriteLine(Roster());
    }
}

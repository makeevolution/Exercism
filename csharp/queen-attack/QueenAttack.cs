using System;
using System.Linq;
using System.Collections.Generic;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {

        if ((white.Row == black.Row) || (white.Column == black.Column) || (Math.Abs(white.Column-black.Column)==Math.Abs(white.Row-black.Row)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static Queen Create(int row, int column)
    {
        List<int> row_and_col = new List<int> {row,column};
        
        if (row_and_col.Where(x => (x<0 | x>=8)).ToList().Count > 0) throw new ArgumentOutOfRangeException() ;
        
        return new Queen(row,column);
    }
}
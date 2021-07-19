using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private Direction direction;
    private int x;
    private int y;
    public RobotSimulator(Direction direction, int x, int y)
    {
        // Use "this" to refer to the fields instead of the arguments
        // If the fields have a different name (e.g. dir instead
        // of direction), then "this" is not needed!

        this.direction = direction;
        this.x = x;
        this.y = y;
    }

    public Direction Direction
    {
        get
        {
            return this.direction;
        }
    }

    public int X
    {
        get
        {
            return this.x;
        }
    }

    public int Y
    {
        get
        {
            return this.y;
        }
    }

    public void Move(string instructions)
    {
        foreach (char item in instructions)
        {
            if (item == 'R')
            {
                // typeof is used to get the enum elements into strings
                if ((int)this.direction == 3){
                    this.direction = (Direction)0;
                }
                else
                {
                    this.direction =(Direction)((int)this.direction + 1);
                }
            }
            else if (item == 'L')
            {
                // typeof is used to get the enum elements into strings
                if ((int)this.direction == 0){
                    this.direction = (Direction)3;
                }
                else
                {
                    this.direction = (Direction)((int)this.direction - 1);
                }
            }
            else if (item == 'A')
            {
                if (this.direction.ToString() == "North")
                { 
                    this.y++;
                }
                else if (this.direction.ToString() == "South")
                {
                    this.y--;
                }
                else if (this.direction.ToString() == "West")
                {
                    this.x--;
                }
                else if (this.direction.ToString() == "East")
                {
                    this.x++;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
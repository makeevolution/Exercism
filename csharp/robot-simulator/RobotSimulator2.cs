using System;
// This alternative program uses auto-property instead of traditional 
// getter-setter
public enum Direction2
{
    North,
    East,
    South,
    West
}

public class RobotSimulator2
{
    // The difference between using an auto-property and traditional 
    // getter-setter is that with auto-property, we do not have to
    // create backing fields. Also, the name of the constructor
    // for each field becomes the field variable itself.
    public RobotSimulator2(Direction2 direction2, int x, int y)
    {
        // Here, "this" is not actually needed since the argument
        // name and the field name is different, but just put it 
        // there for learning purposes. "this" is still needed 
        // for Direction2 to distinguish between referring to the
        // enum definition or the constructor.

        this.Direction2 = direction2;
        this.X = x;
        this.Y = y;
    }

    public Direction2 Direction2 { get ; private set;}

    public int X {get ; private set;}

    public int Y {get ; private set;}

    public void Move(string instructions)
    {
        foreach (char item in instructions)
        {
            if (item == 'R')
            {
                this.Direction2 = (Direction2)(((int)this.Direction2+1)%4);
            }
            else if (item == 'L')
            {
                this.Direction2 = (Direction2)(((int)this.Direction2 + 4 -1)%4);

            }
            else if (item == 'A')
            {
                if (this.Direction2.ToString() == "North")
                { 
                    this.Y++;
                }
                else if (this.Direction2.ToString() == "South")
                {
                    this.Y--;
                }
                else if (this.Direction2.ToString() == "West")
                {
                    this.X--;
                }
                else if (this.Direction2.ToString() == "East")
                {
                    this.X++;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
// This file was auto-generated based on version 3.2.0 of the canonical data.

using Xunit;

public class RobotSimulator2Tests
{
    [Fact]
    public void Create_robot_at_origin_facing_north()
    {
        var sut = new RobotSimulator2(Direction2.North, 0, 0);
        Assert.Equal(Direction2.North, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Create_robot_at_negative_position_facing_south()
    {
        var sut = new RobotSimulator2(Direction2.South, -1, -1);
        Assert.Equal(Direction2.South, sut.Direction2);
        Assert.Equal(-1, sut.X);
        Assert.Equal(-1, sut.Y);
    }

    [Fact]
    public void Rotating_clockwise_changes_north_to_east()
    {
        var sut = new RobotSimulator2(Direction2.North, 0, 0);
        sut.Move("R");
        Assert.Equal(Direction2.East, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Rotating_clockwise_changes_east_to_south()
    {
        var sut = new RobotSimulator2(Direction2.East, 0, 0);
        sut.Move("R");
        Assert.Equal(Direction2.South, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Rotating_clockwise_changes_south_to_west()
    {
        var sut = new RobotSimulator2(Direction2.South, 0, 0);
        sut.Move("R");
        Assert.Equal(Direction2.West, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Rotating_clockwise_changes_west_to_north()
    {
        var sut = new RobotSimulator2(Direction2.West, 0, 0);
        sut.Move("R");
        Assert.Equal(Direction2.North, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Rotating_counter_clockwise_changes_north_to_west()
    {
        var sut = new RobotSimulator2(Direction2.North, 0, 0);
        sut.Move("L");
        Assert.Equal(Direction2.West, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Rotating_counter_clockwise_changes_west_to_south()
    {
        var sut = new RobotSimulator2(Direction2.West, 0, 0);
        sut.Move("L");
        Assert.Equal(Direction2.South, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Rotating_counter_clockwise_changes_south_to_east()
    {
        var sut = new RobotSimulator2(Direction2.South, 0, 0);
        sut.Move("L");
        Assert.Equal(Direction2.East, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Rotating_counter_clockwise_changes_east_to_north()
    {
        var sut = new RobotSimulator2(Direction2.East, 0, 0);
        sut.Move("L");
        Assert.Equal(Direction2.North, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Moving_forward_one_facing_north_increments_y()
    {
        var sut = new RobotSimulator2(Direction2.North, 0, 0);
        sut.Move("A");
        Assert.Equal(Direction2.North, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(1, sut.Y);
    }

    [Fact]
    public void Moving_forward_one_facing_south_decrements_y()
    {
        var sut = new RobotSimulator2(Direction2.South, 0, 0);
        sut.Move("A");
        Assert.Equal(Direction2.South, sut.Direction2);
        Assert.Equal(0, sut.X);
        Assert.Equal(-1, sut.Y);
    }

    [Fact]
    public void Moving_forward_one_facing_east_increments_x()
    {
        var sut = new RobotSimulator2(Direction2.East, 0, 0);
        sut.Move("A");
        Assert.Equal(Direction2.East, sut.Direction2);
        Assert.Equal(1, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Moving_forward_one_facing_west_decrements_x()
    {
        var sut = new RobotSimulator2(Direction2.West, 0, 0);
        sut.Move("A");
        Assert.Equal(Direction2.West, sut.Direction2);
        Assert.Equal(-1, sut.X);
        Assert.Equal(0, sut.Y);
    }

    [Fact]
    public void Follow_series_of_instructions_moving_east_and_north_from_readme()
    {
        var sut = new RobotSimulator2(Direction2.North, 7, 3);
        sut.Move("RAALAL");
        Assert.Equal(Direction2.West, sut.Direction2);
        Assert.Equal(9, sut.X);
        Assert.Equal(4, sut.Y);
    }

    [Fact]
    public void Follow_series_of_instructions_moving_west_and_north()
    {
        var sut = new RobotSimulator2(Direction2.North, 0, 0);
        sut.Move("LAAARALA");
        Assert.Equal(Direction2.West, sut.Direction2);
        Assert.Equal(-4, sut.X);
        Assert.Equal(1, sut.Y);
    }

    [Fact]
    public void Follow_series_of_instructions_moving_west_and_south()
    {
        var sut = new RobotSimulator2(Direction2.East, 2, -7);
        sut.Move("RRAAAAALA");
        Assert.Equal(Direction2.South, sut.Direction2);
        Assert.Equal(-3, sut.X);
        Assert.Equal(-8, sut.Y);
    }

    [Fact]
    public void Follow_series_of_instructions_moving_east_and_north()
    {
        var sut = new RobotSimulator2(Direction2.South, 8, 4);
        sut.Move("LAAARRRALLLL");
        Assert.Equal(Direction2.North, sut.Direction2);
        Assert.Equal(11, sut.X);
        Assert.Equal(5, sut.Y);
    }
}
using System;

namespace ClassesProject;

public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(Point newLocation)
    {
        if (newLocation == null)
        {
            throw new ArgumentNullEexception("newLocation");
        }

        this.Move(newLocation.X, newLocation.Y);
    }
}

[Serializable]
internal class ArgumentNullEexception : Exception
{
    public ArgumentNullEexception()
    {
    }

    public ArgumentNullEexception(string? message) : base(message)
    {
    }

    public ArgumentNullEexception(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
using System;

namespace ClassesInheritance;

public class PresentationObject
{
    public int With { get; set; }
    public int Height { get; set; }

    public void Copy()
    {
        System.Console.WriteLine("Object copied to clipboard.");
    }

    public void Duplicate()
    {
        System.Console.WriteLine("Object duplicated");
    }
}

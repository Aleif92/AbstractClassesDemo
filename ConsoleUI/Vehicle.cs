using System;

namespace ConsoleUI;

public abstract class Vehicle
{

    public string Year { get; set; } = "Default Value";
    public string Make { get; set; } = "Default Value";
    public string Model { get; set; } = "Default Value";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Default Virtual Drive Method");
    }

}
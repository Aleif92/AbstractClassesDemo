using System;

namespace ConsoleUI;

public class Motorcycle: Vehicle
{
    public bool HasSideCar { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle is driving..");
    }
    
    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle Virtual Drive Method");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             Done*/ 

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */// -Done

            // Create a list of Vehicle called vehicles
            var vehicle = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            var car1 = new Car() { HasTrunk = true, Year = "2020", Make = "Honda",Model = "Civic"};
            var motorcycle1 = new Motorcycle() { HasSideCar = true,Make = "Honda",Model = "NX500",Year = "2020"};
            Vehicle vehicle1 = new Car() { Make = "Ford",HasTrunk = true,Model = "F-150",Year = "2020"};
            Vehicle motorcycle2 = new Motorcycle() { Make = "Honda",HasSideCar = false,Model = "Adventure",Year = "2020"};

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicle.Add(car1);
            vehicle.Add(motorcycle1);
            vehicle.Add(motorcycle2);
            vehicle.Add(vehicle1);

            foreach (var ride in vehicle
                     )
            {
              Console.WriteLine($"Year: {ride.Year}");
              Console.WriteLine($"Make: {ride.Make}");
              Console.WriteLine($"Model: {ride.Model}");
              Console.WriteLine();
              Console.WriteLine();
              ride.DriveAbstract();
              ride.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle
            

            #endregion            
            Console.ReadLine();
        }
    }
}

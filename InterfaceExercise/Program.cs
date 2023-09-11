using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car
            {
                companyYear = 2019,
                companyName = "Kia",
                companyModel = "Optima LX Sedan",

                needsOilChange = false,
                hasWorkingBrakes = false,
                hasBrokenWindows = true,
                hasOldTires = true,

                hasFunctionalTrunk = true,
                hasSpareWheel= false,
                
            };

            var truck = new Truck
            {
                companyYear = 2020,
                companyName = "Ram",
                companyModel = "1500",

                needsOilChange = false,
                hasWorkingBrakes = true,
                hasBrokenWindows = true,
                hasOldTires = false,

                hasFunctionalTailgates = true,
                hasCleanBedFloor = false,

            };

            var suv = new SUV
            {
                companyYear = 2020,
                companyName = "Jeep",
                companyModel = "Compass",

                needsOilChange = false,
                hasWorkingBrakes = false,
                hasBrokenWindows = true,
                hasOldTires = true,

                hasFunctionalSunRoof = false,
                canDriveRoughSurface = true,

            };

            var repairList = new List<IVehicle>() { car, truck, suv};

            foreach (IVehicle vehicle in repairList)
            {
                vehicle.DisplayInfo();
                Console.WriteLine("");
                vehicle.DiplayRepairList();
                vehicle.SpecificList();
                Console.WriteLine("");
                Console.WriteLine("-------");
                
            }

            
        }
    }
}

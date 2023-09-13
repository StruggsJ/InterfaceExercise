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
                CompanyYear = 2019,
                CompanyName = "Kia",
                CompanyModel = "Optima LX Sedan",

                NeedsOilChange = false,
                HasWorkingBrakes = false,
                HasBrokenWindows = true,
                HasOldTires = true,

                HasFunctionalTrunk = true,
                HasSpareWheel= false,
                
            };

            var truck = new Truck
            {
                CompanyYear = 2020,
                CompanyName = "Ram",
                CompanyModel = "1500",

                NeedsOilChange = false,
                HasWorkingBrakes = true,
                HasBrokenWindows = true,
                HasOldTires = false,

                HasFunctionalTailgates = true,
                HasCleanBedFloor = false,

            };

            var suv = new SUV
            {
                CompanyYear = 2020,
                CompanyName = "Jeep",
                CompanyModel = "Compass",

                NeedsOilChange = false,
                HasWorkingBrakes = false,
                HasBrokenWindows = true,
                HasOldTires = true,

                HasFunctionalSunRoof = false,
                CanDriveRoughSurface = true,

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

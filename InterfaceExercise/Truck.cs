using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In each of your car, truck, and suv classes

/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public string companyName { get; set; }
        public string companyModel { get; set; }
        public int companyYear { get; set; }


        public bool needsOilChange { get; set; }
        public bool hasWorkingBrakes { get; set; }
        public bool hasBrokenWindows { get; set; }
        public bool hasOldTires { get; set; }


        public bool hasFunctionalTailgates { get; set; } = true;
        public bool hasCleanBedFloor { get; set; } = true;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {companyName}");
            Console.WriteLine($"Model: {companyModel}");
            Console.WriteLine($"Year: {companyYear}");

        }

        public void DiplayRepairList()
        {
            Console.WriteLine($"Needs Oil Change: {needsOilChange}");
            Console.WriteLine($"Needs Brakes Replaced: {hasWorkingBrakes}");
            Console.WriteLine($"Needs Windows Replaced: {hasBrokenWindows}");
            Console.WriteLine($"Needs Tires Replaced: {hasOldTires}");
        }

        public void SpecificList()
        {
            Console.WriteLine($"Needs Tailgates Repair: {hasFunctionalTailgates}");
            Console.WriteLine($"Bed Floor Needs Cleaning: {hasCleanBedFloor}");
        }

    }
}

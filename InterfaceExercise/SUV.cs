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
    public class SUV : ICompany, IVehicle
    {
        public string CompanyName { get; set; }
        public string CompanyModel { get; set; }
        public int CompanyYear { get; set; }


        public bool NeedsOilChange { get; set; }
        public bool HasWorkingBrakes { get; set; }
        public bool HasBrokenWindows { get; set; }
        public bool HasOldTires { get; set; }


        public bool HasFunctionalSunRoof { get; set; } = true;
        public bool CanDriveRoughSurface { get; set; } = true;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {CompanyName}");
            Console.WriteLine($"Model: {CompanyModel}");
            Console.WriteLine($"Year: {CompanyYear}");

        }

        public void DiplayRepairList()
        {
            Console.WriteLine($"Needs Oil Change: {NeedsOilChange}");
            Console.WriteLine($"Needs Brakes Replaced: {HasWorkingBrakes}");
            Console.WriteLine($"Needs Windows Replaced: {HasBrokenWindows}");
            Console.WriteLine($"Needs Tires Replaced: {HasOldTires}");
        }

        public void SpecificList()
        {
            Console.WriteLine($"Needs Sun Roof Repairs: {HasFunctionalSunRoof}");
            Console.WriteLine($"Capable Rough Terrain Driving: {CanDriveRoughSurface}");
        }

    }
}

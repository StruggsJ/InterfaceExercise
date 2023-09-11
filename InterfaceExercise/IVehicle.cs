using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */

namespace InterfaceExercise
{
    public interface IVehicle
    {

        bool needsOilChange { get; set; }

        bool hasWorkingBrakes { get; set; }

        bool hasBrokenWindows { get; set; }

        bool hasOldTires { get; set; }

        public void DiplayRepairList();

        public void SpecificList();

        public void DisplayInfo();

    }
}

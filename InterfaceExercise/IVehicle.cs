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

        bool NeedsOilChange { get; set; }

        bool HasWorkingBrakes { get; set; }

        bool HasBrokenWindows { get; set; }

        bool HasOldTires { get; set; }

        public void DiplayRepairList();

        public void SpecificList();

        public void DisplayInfo();

    }
}

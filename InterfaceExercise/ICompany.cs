using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In ICompany

/*Create 2 members that are specific to each every company
 * regardless of vehicle type.
 *
 *
 * Example: public string Logo { get; set; }
 */


namespace InterfaceExercise
{
    public interface ICompany
    {
        string CompanyName { get; set; } //Car's Make

        string CompanyModel { get; set; }

        int CompanyYear { get; set; }

        

    }
}

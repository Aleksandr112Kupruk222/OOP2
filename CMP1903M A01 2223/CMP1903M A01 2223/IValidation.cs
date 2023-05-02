using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal interface IValidation
    {
        // Validates user input for an integer within a specified range
        // Returns the validated integer value
        int IntValidation(string message, int minRange, int maxRange);
        // Validates user input for a double within a specified range
        // Returns the validated double value
        double DoubleValidation(string message, int minRange, int maxRange);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    static class VehicleFactory
    {
        
         public static IVehicle GetVehicle(int numberOfTires)
         {
            if (numberOfTires > 4)
            {
                return new BigRig();
            }
            else if (numberOfTires == 4)
            {
                return new Car();
            }
            else
            {
                return new Motorcycle();
            }
         }
    }
}

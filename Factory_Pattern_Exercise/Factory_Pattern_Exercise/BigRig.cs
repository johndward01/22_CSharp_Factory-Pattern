using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a new BigRig!");
        }
    }
}

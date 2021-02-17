using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }
    }
}

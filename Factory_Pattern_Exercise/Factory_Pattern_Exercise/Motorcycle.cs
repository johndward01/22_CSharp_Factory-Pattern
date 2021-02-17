using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle!");
        }
    }
}

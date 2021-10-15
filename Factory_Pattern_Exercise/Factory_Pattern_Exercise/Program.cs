using System;
using System.Collections.Generic;

namespace Factory_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = true;
            List<IVehicle> vehicles = new List<IVehicle>();

            while (finished == true)
            {
                int vehicleType = UI.GetVehicleType();
                var vehicleList = UI.GetAndAddToVehicleList(vehicles, vehicleType);
                UI.TraverseVehicleList(vehicleList);
                finished = UI.QuitOrContinue(); 
            }

        }
    }
}

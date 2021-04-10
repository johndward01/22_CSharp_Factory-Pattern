using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    public static class UI
    {
        public static int GetVehicleType()
        {
            Console.WriteLine("What type of vehicle would you like to create?");
            Console.WriteLine();
            Console.WriteLine($"Type 1 for: Car\n" +
                              $"Type 2 for: Motorcycle\n" +
                              $"Type 3 for: BigRig\n");
            Console.WriteLine();
            var vehicleType = int.Parse(Console.ReadLine());
            return vehicleType;
        }


        public static List<IVehicle> GetAndAddToVehicleList(List<IVehicle> vehicles, int vehicleType) 
        {          
            if (vehicleType == 1)
            {
                vehicles.Add(VehicleFactory.GetVehicle(4));
            }
            else if (vehicleType == 2)
            {
                vehicles.Add(VehicleFactory.GetVehicle(2));
            }
            else
            {
                vehicles.Add(VehicleFactory.GetVehicle(18));
            }

            return vehicles;
        }


        public static void TraverseVehicleList(List<IVehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine();
                vehicle.Drive();
                Console.WriteLine();
            }
        }

        public static bool QuitOrContinue()
        {
            bool continuing = false;
            Console.WriteLine("Would you like to create another vehicle? Type 'yes' or 'no'");
            var additionalVehicle = Console.ReadLine().ToLower();

            if (additionalVehicle == "yes")
            {
                continuing = true;
            }
            else
            {
                Console.WriteLine("Thank you for choosing the vehicle factory!");                
            }

            return continuing;
        }




    }
}

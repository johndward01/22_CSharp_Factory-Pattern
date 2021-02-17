using System;

namespace Factory_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("What type of vehicle would you like to create?");
            Console.WriteLine($"Type 1 for: Car" +
                              $"Type 2 for: Motorcycle" +
                              $"Type 3 for: BigRig");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                VehicleFactory.GetVehicle(4);
            }
            else if (userInput == 2)
            {
                VehicleFactory.GetVehicle(2);
            }
            else
            {
                VehicleFactory.GetVehicle(18);
            }
        }
    }
}

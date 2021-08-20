using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleFactory = new Factory();
            var vehicle1 = vehicleFactory.NewVehicle("Dacia", "Logan", 2020, "Petrol", 1.6);
            var vehicle2 = vehicleFactory.NewVehicle("Audi", "A6", 2021, "Diesel", 3.0);
        }
    }
}

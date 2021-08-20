using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Factory
    {
        public Vehicle NewVehicle(string make, string model, int fabricationYear, string fuelType, double cubicCapacity)
        {
            var vehicle = new Vehicle(make, model, fabricationYear, fuelType, cubicCapacity);

            ShowVehicle(vehicle);
            return vehicle;
        }

        private void ShowVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Created a new vehicle \n" + vehicle.ToString());
        }
    }
}

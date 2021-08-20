using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Vehicle
    {
        public Vehicle(string make, string model, int fabricationYear, string fuelType, double cubicCapacity)
        {
            Make = make;
            Model = model;
            FabricationYear = fabricationYear;
            FuelType = fuelType;
            CubicCapacity = cubicCapacity;
        }

        public string Make { get; private set; }
        public string Model { get; private set; }
        public int FabricationYear { get; private set; }
        public string FuelType { get; private set; }
        public double CubicCapacity { get; private set; }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Fabr. Year: {FabricationYear}, {FuelType}, {CubicCapacity}";
        }
    }
}

using System;

namespace Models
{
    public interface IVehicle
    {
        void VehicleType();
    }

    public class PetrolCar : IVehicle
    {
        public void VehicleType()
        {
            Console.WriteLine("This is a petrol car");
        }
    }

    public class DieselCar : IVehicle
    {
        public void VehicleType()
        {
            Console.WriteLine("This is a diesel car");
        }
    }

    public class ElectricCar : IVehicle
    {
        public void VehicleType()
        {
            Console.WriteLine("This is an electric car");
        }
    }

    public class Truck : IVehicle
    {
        public void VehicleType()
        {
            Console.WriteLine("This is a truck");
        }
    }
}

using System;
using Models;

namespace Factory
{
    public class Admin
    {
        private readonly IVehicle vehicle;

        public Admin(IVehicle vehicleIOC)
        {
            vehicle = vehicleIOC;
        }

        public void GetVehicleType()
        {
            vehicle.VehicleType();
        }
    }
}

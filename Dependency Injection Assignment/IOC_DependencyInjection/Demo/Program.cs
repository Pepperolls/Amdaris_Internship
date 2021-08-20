using System;
using Ninject;
using Ninject.Modules;
using Factory;
using Models;
using System.Reflection;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            IEnumerable<IVehicle> vehicles = kernel.GetAll<IVehicle>();

            foreach(var vehicle in vehicles)
            {
                var admin = new Admin(vehicle);
                admin.GetVehicleType();
            }
        }
    }

    public class DependencyInjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IVehicle>().To<PetrolCar>();
            Bind<IVehicle>().To<DieselCar>();
            Bind<IVehicle>().To<ElectricCar>();
            Bind<IVehicle>().To<Truck>();
        }
    }
}

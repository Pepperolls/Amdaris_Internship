using System;

namespace FacadeDemo
{
    public class Car
    {
        public int Fuel;
        public int EngineOil;
        public int CoolingLiquid;

        public Car(int fuel, int engineOil, int coolingLiquid)
        {
            Fuel = fuel;
            EngineOil = engineOil;
            CoolingLiquid = coolingLiquid;
        }
    }
    public class Fuel
    {
        public bool HasEnoughFuel(int fuel)
        {
            return fuel > 0;
        }
    }

    public class EngineOil
    {
        public bool HasEnoughEngineOil(int engineOil)
        {
            return engineOil > 0;
        }
    }

    public class CoolingLiquid
    {
        public bool HasEnoughCoolingLiquid(int coolingLiquid)
        {
            return coolingLiquid > 0;
        }
    }

    public class StartEngine
    {
        Fuel fuel = new Fuel();
        EngineOil engineOil = new EngineOil();
        CoolingLiquid coolingLiquid = new CoolingLiquid();
        public void CanStartEngine(Car car)
        {
            Console.WriteLine("Trying to start the car's engine");
            bool canStart = true;

            if (!fuel.HasEnoughFuel(car.Fuel))
            {
                canStart = false;
                Console.WriteLine("Please refuel!");
            }
            else if (!engineOil.HasEnoughEngineOil(car.EngineOil))
            {
                canStart = false;
                Console.WriteLine("Please check oil level!");
            }
            else if (!coolingLiquid.HasEnoughCoolingLiquid(car.CoolingLiquid))
            {
                canStart = false;
                Console.WriteLine("Please check cooling liquid level!");
            }

            if (canStart) Console.WriteLine("Engine started successfully");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StartEngine startEngine = new StartEngine();
            Car car = new Car(0, 10, 10);
            startEngine.CanStartEngine(car);

            Car car2 = new Car(10, 10, 10);
            startEngine.CanStartEngine(car2);
        }
    }
}

using System;

namespace Hierarchy
{
    abstract class Vehicle
    {
        public abstract void Drive();
    }
    class Car : Vehicle
    {
        public String Make;
        public String Model;
        public override void Drive()
        {
            Console.WriteLine("You are now driving");
        }
    }
    class FuelTypeCar : Car
    {
        public String FuelType;
        public uint EngineCc;
        public uint Fuel;
        public override void Drive()
        {
            Console.WriteLine("You are now driving. Fuel remaining:" + Fuel);
        }
    }
    class ElectricCar : Car
    {
        public uint BatteryCapacity;
        public uint BatteryLeft;
        public override void Drive()
        {
            Console.WriteLine("You are now driving. Battery remaining:" + BatteryLeft);
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

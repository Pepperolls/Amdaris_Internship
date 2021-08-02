using System;

namespace ClassesAssignment
{
    class Car
    {
        private string make;
        private string model;
        private string fuelType;
        private uint engineCc;
        private uint fuel;
        private uint mileage;
        private bool isEngineStarted;
        public Car(string make, string model, string fuelType, uint engineCc)
        {
            this.make = make;
            this.model = model;
            this.fuelType = fuelType;
            this.engineCc = engineCc;
            fuel = 100;
            mileage = 0;
            isEngineStarted = false;
        }
        public uint Fuel
        {
            get
            {
                Console.WriteLine("Fuel left:");
                return fuel;
            }
            set
            {
                fuel = value;
            }
        }
        public bool HasEnoughFuel()
        {
            return fuel > 0;
        }

        public void StartEngine()
        {
            if(HasEnoughFuel())
            {
                isEngineStarted = true;
                fuel--;
            }
            else
            {
                Console.WriteLine("Please refuel!");
            }
        }

        public void StopEngine()
        {
            isEngineStarted = false;
        }

        public void Drive()
        {
            if (isEngineStarted)
            {
                if (HasEnoughFuel())
                {
                    fuel--;
                    mileage++;
                }
                else
                {
                    StopEngine();
                    Console.WriteLine("Please refuel!");
                }
            }
        }

        public override string ToString()
        {
            return $"{make} {model}: {mileage} km, range: {fuel}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car prototype = new Car("Audi", "A6", "Petrol", 3000);
            Console.WriteLine(prototype);

            Console.WriteLine(prototype.Fuel);
            prototype.Fuel = 70;
            Console.WriteLine(prototype.Fuel);
        }
    }
}

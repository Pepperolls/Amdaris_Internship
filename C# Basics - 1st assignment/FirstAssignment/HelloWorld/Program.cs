using System;

namespace HelloWorld
{
    public struct Time
    {
        public int Hour;
        public int Minutes;
        public int Seconds;

        public Time(int Hour, int Minutes, int Seconds)
        {
            this.Hour = Hour;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public override string ToString()
        {
            return $"{Hour}:{Minutes}:{Seconds}";
        }
    }

    public class Car
    {
        public string Make;
        public string Model;
        public string FuelType;
        public double EngineCC;

        public Car(string Make, string Model, string FuelType, double EngineCC)
        {
            this.Make = Make;
            this.Model = Model;
            this.FuelType = FuelType;
            this.EngineCC = EngineCC;
        }
        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nEngine: {EngineCC}, {FuelType}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time now = new Time(15, 36, 48);
            Console.WriteLine($"The time is: {now}");

            Car car = new Car("Dacia", "Logan", "Petrol", 1.4);
            Console.WriteLine($"\n{car}");
        }
    }
}
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

            string Make = Console.ReadLine();
            string Model = Console.ReadLine();
            string FuelType = Console.ReadLine();
            double EngineCC = Convert.ToDouble(Console.ReadLine());

            Car car = new Car(Make, Model, FuelType, EngineCC);
            Console.WriteLine($"\n{car}");
        }
    }
}
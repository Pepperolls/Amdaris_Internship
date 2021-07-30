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
        static void MethodForNone(int x, Time time)
        {
            x += 10;
            time.Hour += 10;
            time.Minutes += 10;
            time.Seconds += 10;

            Console.WriteLine("The number inside the method: " + x);
            Console.WriteLine($"The time inside the method: {time}");
        }

        static void MethodForRef(ref int x, ref Time time)
        {
            x += 10;
            time.Hour += 10;
            time.Minutes += 10;
            time.Seconds += 10;

            Console.WriteLine("The number inside the method: " + x);
            Console.WriteLine($"The time inside the method: {time}");
        }

        static void MethodForOut(out int x, out Time time)
        {
            x = 99;
            time = new Time { Hour = 15, Minutes = 15, Seconds = 15 };

            Console.WriteLine("The number inside the method: " + x);
            Console.WriteLine($"The time inside the method: {time}");
        }

        static void Main(string[] args)
        {
            //These are the instances of a value/reference type
            Time now = new Time { Hour = 15, Minutes = 36, Seconds = 48 };
            Console.WriteLine($"The time is: {now}");

            Console.WriteLine("Enter car make:");
            string Make = Console.ReadLine();
            Console.WriteLine("Enter car model:");
            string Model = Console.ReadLine();
            Console.WriteLine("Enter car fuel type:");
            string FuelType = Console.ReadLine();
            Console.WriteLine("Enter car engine cubic capacity:");
            double EngineCC = Convert.ToDouble(Console.ReadLine());

            Car car = new Car(Make, Model, FuelType, EngineCC);
            Console.WriteLine($"\n{car}");

            //Methods and examples for each type of parameter modifier
            Console.WriteLine("\nMethod for no modifier (passed by value):");

            int x = 10;
            Time time = new Time { Hour = 10, Minutes = 10, Seconds = 10 };
            Console.WriteLine("The number before: " + x);
            Console.WriteLine($"The time before: {time}\n");

            MethodForNone(x, time);

            Console.WriteLine("\nThe number after: " + x);
            Console.WriteLine($"The time after: {time}\n");
            //Variabilele cu care se lucreaza in interiorul metodei sunt doar copii, motiv pentru care cele din main raman nemodificate in urma apelului.

            Console.WriteLine("\nMethod for ref modifier (passed by reference):");

            Console.WriteLine("The number before: " + x);
            Console.WriteLine($"The time before: {time}\n");

            MethodForRef(ref x, ref time);

            Console.WriteLine("\nThe number after: " + x);
            Console.WriteLine($"The time after: {time}\n");
            //De data aceasta, variabilele sunt transmise prin referinta, deci x-ul si time-ul din interiorul metodei ajung sa pointeze la adresa din memorie
            //a variabilelor initiale. Astfel, modificand in metoda, se schimba si in memorie, nu se creaza o copie ca si la transmiterea prin valoare.


            Console.WriteLine("\nMethod for out modifier (passed by reference):");

            int y;
            Time time1 = new Time();
            Console.WriteLine("The number is not assigned before the method");
            Console.WriteLine($"The time before: {time1}\n");

            MethodForOut(out x, out time);
            Console.WriteLine("\nThe number after: " + x);
            Console.WriteLine($"The time after: {time}\n");
            //Singura diferenta este faptul ca transmiterea prin modificatorul out ne permite sa folosim parametri unassigned inainte de apelul metodei.


            //Boxing&Unboxing

            Console.WriteLine("Enter number");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("z: " + z);

            object obj = x; //Ii dam wrap lui x intr-un obiect (boxing)
            Console.WriteLine("Obj: " + obj);

            // int y = obj; - eroare
            int w = (int)obj; //"Convertim" continutul obiectului inapoi la tipul int, si il salvam in y (unboxing)
            Console.WriteLine("y: " + w);
        }
    }
}
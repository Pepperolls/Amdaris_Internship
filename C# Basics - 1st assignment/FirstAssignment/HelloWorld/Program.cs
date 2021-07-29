using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x: " + x);

            object obj = x; //Ii dam wrap lui x intr-un obiect (boxing)
            Console.WriteLine("Obj: " + obj);

            // int y = obj; - eroare
            int y = (int)obj; //"Convertim" continutul obiectului inapoi la tipul int, si il salvam in y (unboxing)
            Console.WriteLine("y: " + y);
        }
    }
}
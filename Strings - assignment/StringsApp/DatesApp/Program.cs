using System;

namespace DatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);

            DateTime date2 = DateTime.UtcNow;
            Console.WriteLine(date2);

            DateTimeOffset date3 = DateTimeOffset.Now;
            Console.WriteLine(date3);

            date2 = DateTime.Now;
            date1 = date1.AddMinutes(10);
            Console.WriteLine(date1);

            TimeSpan dif = date1 - date2;
            Console.WriteLine(dif);

            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));

            DateTime date4 = DateTime.Now.AddDays(1).AddMinutes(1).AddHours(1).AddSeconds(1);
            Console.WriteLine(date4);

            TimeSpan dif2 = date4 - DateTime.Now;
            Console.WriteLine(dif2);

        }
    }
}

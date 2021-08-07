using System;
using System.Collections.Generic;

namespace Enums_Collections
{
    class Program
    {

        enum Names { 
            Alex,
            Andrei,
            Paul
        };
        static void Main(string[] args)
        {
            //int i = null; -> eroare
            int? i = null;
            Console.WriteLine(i == null);

            int j = i ?? 10;
            Console.WriteLine(j);

            foreach (string name in Enum.GetNames(typeof(Names)))
            {
                Console.WriteLine(name);
            }

            IEnumerable<int> enumerable = new int[] { 1, 2, 3, 4 };

            foreach (int num in enumerable)
            {
                Console.WriteLine(num);
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                {1, "Alex"},
                {2, "Andrei"},
                {3, "Paul"}
            };

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[3]);

        }
    }
}
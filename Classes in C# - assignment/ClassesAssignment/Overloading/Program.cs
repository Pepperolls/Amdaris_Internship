using System;

namespace Overloading
{
    class Students
    {
        public void ClassAttendance(string name)
        {
            Console.WriteLine($"Only {name} has attended today's lesson.");
        }

        public void ClassAttendance(string name1, string name2)
        {
            Console.WriteLine($"Both {name1} and {name2} have attended today's lesson.");
        }

        public void ClassAttendance(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"{name} has attended");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students stud = new Students();
            stud.ClassAttendance("Rares");
            stud.ClassAttendance("Rares", "Norbi");
            stud.ClassAttendance("Rares", "Norbi", "Radu");
        }
    }
}

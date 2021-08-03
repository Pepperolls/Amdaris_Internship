using System;
using System.Text;

namespace StringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Rares";
            string s2 = "Rares";

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(string.Compare(s1, s2));

            string s3 = "ares";
            Console.WriteLine(string.Compare(s1, s3));
            string s4 = "z";
            Console.WriteLine(string.Compare(s1, s4));

            Console.WriteLine(s1.Contains(s3));

            Console.WriteLine(string.Format("{0} {1} {2} {3}", "This", "is", "a", "sample"));
            Console.WriteLine(string.Format("{0} {0} {0} {0}", "This", "is", "a", "sample"));

            string s5 = "Mladin";
            string name1 = $"{s1} {s5}";
            Console.WriteLine(name1);

            string name2 = s1 + " " + s5;
            Console.WriteLine(name2);

            Console.WriteLine(s1.PadRight(6) + s5);

            Console.WriteLine(s1.PadLeft(20));
            Console.WriteLine(s1.Trim());

            s1 = s1.ToLower();
            Console.WriteLine(s1);

            string[] split = s1.Split('r');
            foreach(string piece in split)
            {
                Console.WriteLine(piece);
            }

            string join = string.Join('r', split);
            Console.WriteLine(join);



            //StringBuilder - the main difference between the StringBuilder and String types is the fact that StringBuilder is a mutable string class.
            //This means that modifying a StringBuilder is possible, in contrast to the String type (which creates a new string whenever you change things to
            //another). StringBuilders can be modified by appending, removing, replacing, or inserting characters, and the data is modified accordingly.
            Console.WriteLine('\n');

            StringBuilder sb1 = new StringBuilder("StringBuilder", 100);
            Console.WriteLine(sb1);

            sb1.Append("Type");
            Console.WriteLine(sb1);

            StringBuilder sb2 = new StringBuilder("String", 100);
            sb2.AppendFormat("Build{0}{1}", 'e', 'r');
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder("Builder", 100);
            sb3.Insert(0, "String");
            Console.WriteLine(sb3);

            StringBuilder sb4 = new StringBuilder("zesz", 10);
            sb4.Replace('z', 't');
            Console.WriteLine(sb4);

            sb3.Remove(0, 6);
            Console.WriteLine(sb3);
        }
    }
}

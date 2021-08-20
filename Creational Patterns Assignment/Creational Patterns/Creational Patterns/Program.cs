using System;

namespace Creational_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            singleton.writeName();
        }

        public sealed class Singleton
        {
            private string Name;
            private static readonly Singleton instance = new Singleton("Rares");

            static Singleton() { }

            private Singleton(string name) 
            {
                Name = name;
            }

            public static Singleton Instance
            {
                get
                {
                    return instance;
                }
            }
            public void writeName()
            {
                Console.WriteLine(instance.Name);
            }
        }
    }
}

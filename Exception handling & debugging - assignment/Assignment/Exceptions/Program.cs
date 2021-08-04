using System;

namespace Exceptions
{
    class RandomExceptions
    {
        public void WithdrawFunds(uint balance, uint amount)
        {
            if (amount > balance)
                throw new Exception("Not enough account balance");
            balance -= amount;
            Console.WriteLine($"New account balance: {balance}");
        }
    }

    class Person
    {
        private uint age;

        public Person(uint age)
        {
            this.age = age;
        }
        public void HaveADrink()
        {
            if (age < 18)
                throw new PersonIsNotAnAdultException("Person is not an adult!");
            Console.WriteLine("Enjoy your drink!");
        }
    }
    public class PersonIsNotAnAdultException : Exception
    {
        public PersonIsNotAnAdultException() { }

        public PersonIsNotAnAdultException(string message) : base(message) { }

        public PersonIsNotAnAdultException(string message, Exception inner) : base(message, inner) { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            RandomExceptions a = new RandomExceptions();
            a.WithdrawFunds(10, 10); //Modify the 2nd parameter over 10 to see the exception occur.

            Person p = new Person(17);
            p.HaveADrink();
        }
    }
}

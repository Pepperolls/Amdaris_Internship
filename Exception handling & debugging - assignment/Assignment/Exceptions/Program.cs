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

            Person p1 = new Person(18); //Modify number below 18 to see the exception occur.
            p1.HaveADrink();

            int n1;
            int n2;
            try
            {
                Console.WriteLine("First number:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number:");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(n1 / n2);
                
            }
            catch(ArithmeticException exception)
            {
                throw new ArithmeticException("You cannot divide by 0!", exception); //Try reading the 2nd number as 0 to see the exception occur.
            }
            catch(Exception exception)
            {
                throw new Exception("Invalid numbers!", exception); //Try reading some words instead of a number to see the exception occur.
            }
            finally
            {
                Console.WriteLine("Operation successful");
            }
        }
    }
}

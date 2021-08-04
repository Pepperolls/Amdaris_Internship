using System;

namespace Exceptions
{
    class RandomExceptions
    {
        public void WithdrawFunds(int balance, int amount)
        {
            if (amount > balance)
                throw new Exception("Not enough account balance");
            balance -= amount;
            Console.WriteLine($"New account balance: {balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomExceptions a = new RandomExceptions();
            a.WithdrawFunds(10, 11);
        }
    }
}

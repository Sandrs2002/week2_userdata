using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your PIN");
            string Pin = Console.ReadLine();

            if (Pin == "1234")
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("What is your name?");
                string Name = Console.ReadLine();
                Console.WriteLine($"Welcome back, {Name}!");
            }
            else
            {
                Console.WriteLine("Invalid PIN!!!");
            }
        }
    }
}

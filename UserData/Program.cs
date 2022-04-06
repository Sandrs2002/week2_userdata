using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username:");
            string userName = Console.ReadLine();

            if(userName == "admin")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Oops! Invalid username.");
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}

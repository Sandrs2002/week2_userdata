using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if (UserAge < 13)
            {
                Console.WriteLine("You are too young to Instagram.");
            }
            else if (UserAge > 13)
            {
                Console.WriteLine("Welcome to Instagram!");
            }
            else 
            {
                Console.WriteLine("Congratulations! You may use Instagram now.");
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}

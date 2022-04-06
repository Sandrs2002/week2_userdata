using System;

namespace DrivingLisence
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born?");
            int result = 2022 - Convert.ToInt32(Console.ReadLine());

            if (result < 18)
            {
                Console.WriteLine("Too young to drive!");
            }
            else if (result > 18)
            {
                Console.WriteLine("Drive carefully!");
            }
            else
            {
                Console.WriteLine("Congratulations, you may apply for your driving license now!");
            }
        }
    }
}

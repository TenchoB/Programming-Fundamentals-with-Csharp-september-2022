using System;

namespace Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number <= 7)
            {
                Console.WriteLine(days[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}

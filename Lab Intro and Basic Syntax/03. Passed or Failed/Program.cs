using System;

namespace _03._Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            if (input >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else if (input < 3)
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}

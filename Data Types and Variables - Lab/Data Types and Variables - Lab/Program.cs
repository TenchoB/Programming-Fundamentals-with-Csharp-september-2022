using System;

namespace Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            double kms = m / 1000.0;
            Console.WriteLine($"{kms:f2}");
        }
    }
}

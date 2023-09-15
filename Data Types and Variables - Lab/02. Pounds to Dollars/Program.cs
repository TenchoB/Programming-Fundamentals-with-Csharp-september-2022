using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double bp = double.Parse(Console.ReadLine());
            double us = bp * 1.31;
            Console.WriteLine($"{us:f3}");
        }
    }
}

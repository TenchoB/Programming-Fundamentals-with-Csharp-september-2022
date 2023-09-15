using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <= N; i++)
            {
                
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double sum = (days * capsulesCount) * pricePerCapsule;
                total += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");


        }
    }
}

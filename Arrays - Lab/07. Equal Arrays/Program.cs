using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbres2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbres2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {numbers1.Sum()}");

        }
    }
}

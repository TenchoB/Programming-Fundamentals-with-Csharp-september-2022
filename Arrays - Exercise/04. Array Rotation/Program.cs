using System;
using System.Linq;
namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = (Console.ReadLine())
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            for (int r = 1; r <= rotations; r++)
            {
                int firstEl = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }
                numbers[numbers.Length - 1] = firstEl;
            }

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}

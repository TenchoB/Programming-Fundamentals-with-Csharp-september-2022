using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chars = Console.ReadLine()
                .Split()
                .ToArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write($"{chars[i]} ");
            }
        }
    }
}

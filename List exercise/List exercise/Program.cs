using System;
using System.Collections.Generic;
using System.Linq;

namespace List_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 1, 3, 4
            };
            numbers.Add(5);
            numbers.Remove(1);
            numbers.RemoveAt(1);
            numbers.Insert(0, 1);
            numbers.AddRange(new int[] { 6, 7, 8 });
            numbers[2] = 100;

                
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}

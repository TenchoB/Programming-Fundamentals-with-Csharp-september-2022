using System;

namespace Lab_Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string StudentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {StudentName}, Age: {age}, Grade: {grade:F2}");

        }
    }
}

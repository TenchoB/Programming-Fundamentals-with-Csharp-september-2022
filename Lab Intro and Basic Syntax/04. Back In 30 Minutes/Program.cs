using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()) +30;
            if (min > 59)
            {
                hour += 1;
                min -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{min:D2}");
        }
    }
}

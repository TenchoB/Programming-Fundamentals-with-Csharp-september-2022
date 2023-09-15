

namespace _07._Theatre_Promotion
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 18)
            {
                if (typeDay == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (typeDay == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (typeDay == "Holiday")
                {
                    Console.WriteLine("5$");
                }
                
                
            }
            else if (age > 18 && age <= 64 )
            {
                if (typeDay == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (typeDay == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else if (typeDay == "Holiday")
                {
                    Console.WriteLine("12$");
                }

                
            }
            else if (age > 64 && age<=122)
            {
                if (typeDay == "Weekday")
                {
                    Console.WriteLine("12");
                }
                if (typeDay == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                if (typeDay == "Holiday")
                {
                    Console.WriteLine("10$");

                }

            }
            else
            {
                Console.WriteLine("Error!");
            }
           
        }
    }
}

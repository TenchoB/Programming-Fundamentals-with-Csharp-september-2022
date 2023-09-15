using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (day == "Friday")
            {
                switch (groupType)
                {
                    case "Students":
                        price = 8.45;
                        break;
                    case "Business":
                        price = 10.9;
                        break;
                    case "Regular":
                        price = 15;
                        break;
                }
            }
            else if (day == "Saturday")
            {
                switch (groupType)
                {
                    case "Students":
                        price = 9.8;
                        break;
                    case "Business":
                        price = 15.6;
                        break;
                    case "Regular":
                        price = 20;
                        break;
                }

            }
            else if (day == "Sunday")
            {
                switch (groupType)
                {
                    case "Students":
                        price = 10.46;
                        break;
                    case "Business":
                        price = 16;
                        break;
                    case "Regular":
                        price = 22.5;
                        break;
                }
            }
            if (groupType == "Business" && people >= 100)
            {
                people -= 10;
            }
            double totalPrice = people * price;
            if (groupType == "Students" && people >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            
            if (groupType == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}

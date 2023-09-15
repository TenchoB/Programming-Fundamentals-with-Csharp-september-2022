using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int multiplier = int.Parse(Console.ReadLine());
                if (multiplier <= 10)
                {
                    while (multiplier <= 10)
                    {

                        Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
                        multiplier++;

                    }
                }
                else if (multiplier > 10)
                {
                   
                        Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
                        

                }
                
            }
        }
    }
}
    


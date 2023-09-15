using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            //Outer loop represents rows
            for (int row = 1; row <= n; row++)
            {
                

                //Nested loop represents columns
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{row} ");
                }

                //Console new row
                Console.WriteLine();
            }
        }
    }
}

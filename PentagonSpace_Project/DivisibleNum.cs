using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class DivisibleNum
    {
        static void Main(String [] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            String result = num % 5 == 0 ? (num % 11 == 0 ? "Divisible by 11" : " Divisible by 5") : "Divisible by 11";
            Console.WriteLine(result);
        }
    }
}

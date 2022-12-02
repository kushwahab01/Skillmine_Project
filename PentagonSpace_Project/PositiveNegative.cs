using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            String result = num < 0 ? (num > 0 ? "Positive" : "Negative") : "Positive";
            Console.WriteLine(result);
        }
    }
}

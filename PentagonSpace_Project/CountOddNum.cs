using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class CountOddNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int Count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Count = Count + 1;
                }
            }
            Console.WriteLine(Count);
        }
    }
}

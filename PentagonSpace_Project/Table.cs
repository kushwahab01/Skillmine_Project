using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class Table
    {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
        }
    }
}

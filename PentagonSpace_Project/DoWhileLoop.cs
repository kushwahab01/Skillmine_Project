using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class DoWhileLoop
    {
        static void Main(string[] args)
        {
            int n, sum = 0, firstdigit, lastdigit;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            lastdigit = n % 10;
            do
            {
                n = n / 10;
            }while (n >= 10) ;
            firstdigit = n;
            sum = firstdigit + lastdigit;
            Console.WriteLine(sum);
        }
    }
}

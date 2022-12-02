using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class FactorsSum
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                if(i%n==0 && i%1==0)
                {
                    sum = sum + n;
                }
                Console.WriteLine(sum);
            }
                   
        }
    }
}

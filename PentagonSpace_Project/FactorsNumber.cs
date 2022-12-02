using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class FactorsNumber
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;

                }
                
            }
            Console.WriteLine("Sum of factors " + sum);
        }
    }
}

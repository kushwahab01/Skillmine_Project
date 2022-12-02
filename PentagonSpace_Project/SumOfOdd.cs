using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class SumOfOdd
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while(i<=n)

            {
              if(n%i!=0)
                {
                    sum = sum + i;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}

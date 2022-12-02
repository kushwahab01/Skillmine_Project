using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            int n1 = 0;
            int multi = 1;
            while(num>0)
            {
                int digit = num % 10;
                n1 = n1 + digit;
                multi = multi * digit;
                num = num / 10;

            }
            if(n1==multi)
            {
                Console.WriteLine("Number is Spy number");
            }
            else
            {
                Console.WriteLine("Number is not a Spy number");
            }

        }
    }
}

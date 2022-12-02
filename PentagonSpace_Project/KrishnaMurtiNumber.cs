using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class KrishnaMurtiNumber
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
           int temp = n;
            while (n>0)
            {
                int ldigit = n % 10;
                int fact = 1;
                for (int i = 1; i <= ldigit; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
           
                n = n / 10;
            }
            if (temp==sum)
                {
                    Console.WriteLine("Krishnamurti Number" + sum);

                }
                else
                {
                    Console.WriteLine("Not a krishnamurti Number"+sum);
                }
            
        }
    }
}

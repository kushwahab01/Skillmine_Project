using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class DisarinNumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Eter the Number");
            num = int.Parse(Console.ReadLine());

            int len = 0;
            int temp = num;
            int temp1 = num;
            while(num>0)
            {
                int digit = num % 10;
                num = num / 10;
                len++;
            }
            temp = num;
            int sum = 0;
            while(num>0)
            {
                int digit = num % 10;
                int power = 1;
                for(int i=1;i<=len;i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                num = num / 10;
                len--;
            }
            if(temp1==sum)
            {
                Console.WriteLine("Number is Disarian");
            }
            else
            {
                Console.WriteLine("number is not disarian");
            }
        }
    }
}

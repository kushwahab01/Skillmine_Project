﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class SumOfEven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1; i<=10; i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum : " + sum);
        }
    }
}

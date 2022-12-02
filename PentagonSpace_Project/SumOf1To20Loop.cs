using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class SumOf1To20Loop
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while(i<20)
            {
                if(sum>10)
                {
                    sum = sum + i;
                    break;
                    
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}

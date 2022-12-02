using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class SumOfPrimeNumber
    {
      static void Main(string[] args)
        {
           
            int sum = 0;
            for(int num=1; num<=10; num++)
            {
               bool isPrime= true;
                for(int i=2; i<num; i++)
                {
                    if(num%i==0)
                    {
                         isPrime = false;
                        break;
                    }
                }

                if(isPrime==true)
                {
                    Console.WriteLine(num);
                    sum = sum + num;
                }
            }
            Console.WriteLine("Sum of prime" + sum);
        }
    }
}

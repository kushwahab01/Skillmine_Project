using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class SumOf1stAndLastDigit
    {
        static void Main(string[] args)
        {
            int num,Fdigit,Ldigit;
            int sum = 0;
            num = int.Parse(Console.ReadLine());
            Ldigit = num % 10;
            while(num>=10)
            {
                num = num / 10;
                
            }
            Fdigit = num;
            sum = Fdigit + Ldigit;
            Console.WriteLine(sum);
        }
    }
}

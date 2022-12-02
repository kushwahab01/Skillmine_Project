using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class OddEvenSwitch
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            switch(num%2==0)

            {
                case true:Console.WriteLine("Even");
                    break;
                case false:Console.WriteLine("Odd");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter the value of n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of n2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of n3");
            n3 = int.Parse(Console.ReadLine());

            String result = (n1 > n2 && n1 > n3) ? n1 + "n1 is greter" : (n2 > n1 && n2 > n3) ? n2 + "n2 is greter" : "n3 is greter";
            Console.WriteLine(result);
        
        }

    }
}

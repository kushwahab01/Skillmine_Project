using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class TableOf1To5
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    Console.Write(i*j+"   ");
                }
                Console.WriteLine();

            }
           
        }
    }
}

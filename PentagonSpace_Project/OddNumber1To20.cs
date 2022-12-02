using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class OddNumber1To20
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 20; i++)
            {
                if(i%2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}

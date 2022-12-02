using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class NumberDivsible3
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1; i<=50; i++)
            {
                if(i%3==0 || i%5==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

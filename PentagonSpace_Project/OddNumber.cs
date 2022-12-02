using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int i;
            for(i=120; i>=81; i--)
            {
                if(i%2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class Display1To50
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=50)
            {
                if(i%5==0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project.Pattern
{
    class PatternMatching10
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    if(j==1 || j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

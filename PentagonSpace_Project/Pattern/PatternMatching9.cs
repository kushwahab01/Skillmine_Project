using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project.Pattern
{
    class PatternMatching9
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=4; j++)
                {
                    if(j==1 || j==4)
                    {
                        Console.Write("*");

                    }
                    else if(i==2&&j==2 || i==3&&j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project.Pattern
{
    class PatternMatching
    {
        static void Main(string[] args)
        {
            int n = 4;
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

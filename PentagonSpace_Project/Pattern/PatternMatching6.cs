﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project.Pattern
{
    class PatternMatching6
    {
        static void Main(string[] args)
        {
            
            for(char i='A'; i<='D'; i++)
            {
                for(char j='A';j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

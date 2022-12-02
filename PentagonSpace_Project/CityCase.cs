using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class CityCase
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the city");
            string city =Console.ReadLine();

            switch(city)
            {
                case "pune":
                    Console.WriteLine("Welcome to Pune");
                    break;
                case "mumbai":
                    Console.WriteLine("Welcome to mumbai");
                    break;
                case "delhi":
                    Console.WriteLine("Welcome to delhi");
                    break;
                case "banglore":
                    Console.WriteLine("Welcome to Banglore");
                    break;
                default:
                    Console.WriteLine("Choose another city");
                    break;
            }
        }
    }
}

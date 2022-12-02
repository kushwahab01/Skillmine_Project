using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class CalculatorSwitch
    {
       static void Main(string [] args)

        {
            int calculator;
            Console.WriteLine("Enter the number");

            calculator = int.Parse(Console.ReadLine());

            switch(calculator)
            {
                case 1:Console.WriteLine("Perform Addition");
                    break;
                case 2:Console.WriteLine("Perform Multiplcation");
                    break;
                case 3: Console.WriteLine("Perform Substraction");
                    break;
                default: Console.WriteLine("Take another number");
                    break;
                case 4: Console.WriteLine("Perform division");
                    break;
            
            }
        }

    }
}

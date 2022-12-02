using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class Student_Marks
    {
        static void Main(string[] args)
        {
            int sub1,sub2,sub3,sub4,sub5;
            Console.WriteLine("Enter the subject1 marks");
            sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 2 marks");
            sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 3 marks");
            sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 4 marks");
            sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 5 marks");
            sub5 = int.Parse(Console.ReadLine());

            double perc = (sub1 + sub2 + sub3 + sub4 + sub5) * 100 / 500;
            Console.WriteLine("Your percentage is "+perc);

            if(perc>=70)
            {
                Console.WriteLine("Distinct");
            }
            else if(perc>=60 && perc<70)
            {
                Console.WriteLine("First class");
            }
            else if(perc>=50 && perc<60)
            {
                Console.WriteLine("2nd class");
            }
            else if(perc>=35 && perc<50)
            {
                Console.WriteLine("3rd class");
            }
            else
            {
                Console.WriteLine("You are fail");
            }

        }
    }
}

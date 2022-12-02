using System;

namespace PentagonSpace_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;
            Console.WriteLine("Enter the value of n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of n2");
            n2 = int.Parse(Console.ReadLine());
            int area = n1 * n2;
            Console.WriteLine(area);
            
            
        }
    }

    class OddEven
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the value of n1");
            num1 = int.Parse(Console.ReadLine());
            
            if (num1%2==0)
            {
                Console.WriteLine("Number is odd");
            }
            else
            {
                Console.WriteLine("Number is even");
            }
        }
    }

    class Div_01
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the nummber");
            num1 = int.Parse(Console.ReadLine());
            if(num1%5==0)
            {
                Console.WriteLine("Number is divisible by 5");
            }
            else
            {
                Console.WriteLine("Not a divisible by 5");
            }
        }
    }

    


    class Positiv_1
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the value of num1");
            num1 = int.Parse(Console.ReadLine());

            if(num1>0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(num1<0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }



    class NumDiv
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            if(num%3==0)
            {
                Console.WriteLine("Number is divisible by 3");
            }
            else if(num%9==0)
            {
                Console.WriteLine("Number is divisible by 9");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 3 or 9");
            }
        }
    }


    class Vowels01
    {
        static void Main(String[]args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
            {
                Console.WriteLine("It is vowel");
            }
            else
            {
                Console.WriteLine("It is consonant");
            }
        }
    }



    class DayTable
    {
        static void Main(String[]args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("MONDAY");
            }
            else if(n==2)
            {
                Console.WriteLine("TUESDAY");
            }
            else if(n==3)
            {
                Console.WriteLine("WEDNESDAY");
            }
            else if(n==4)
            {
                Console.WriteLine("THURSDAY");
            }
            else if(n==5)
            {
                Console.WriteLine("FRIDAY");

            }
            else if(n==6)
            {
                Console.WriteLine("SATURDAY");
            }
            else if(n==7)
            {
                Console.WriteLine("SUNDAY");
            }
            else
            {
                Console.WriteLine("After Sunday");
            }
        }
    }

    class NeastedStmt
    {
        static void Main(String [] args)

        {
            int n1, n2, n3;
            Console.WriteLine("Enter the number n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number n2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number n3");
            n3 = int.Parse(Console.ReadLine());

            if(n1>n2)
            {
                if(n1>n3)
                {
                    Console.WriteLine("n1 is greater");
                }
            }
            else if(n2>n1)
            {
                if(n2>n3)
                {
                    Console.WriteLine("n2 is greater");
                }
                else
                {
                    Console.WriteLine("n3 is greater");
                }
            }
           
        }
    }



    class LeapYearCk
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year");
            year = int.Parse(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("Year is Leap year");
            }
            else if(year%100==0)
            {
                Console.WriteLine("Year is leap year");
            }
            else if(year%400==0)
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
                 
        }
    }

}

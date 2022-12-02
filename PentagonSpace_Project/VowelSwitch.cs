using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project
{
    class VowelSwitch
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
                {


                case 'a': Console.WriteLine("Vowel");
                    break;
                case 'e':Console.WriteLine("Vowel");
                    break;
                case 'i': Console.WriteLine("Vowel");
                    break;
                case 'o': Console.WriteLine("Vowel");
                    break;
                case 'u': Console.WriteLine("Vowel");
                    break;
                default:Console.WriteLine("Consonent");
                    break;

            }
        }
    }
}

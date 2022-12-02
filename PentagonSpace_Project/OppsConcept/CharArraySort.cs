using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.OppsConcept
{
    class CharArraySort
    {

        public char[] MySortChar(char[] arr)
        {
            for(int i=0; i<arr.Length;i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[i]>arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public static void Main(string[] args)
        {
            char[] a = { 'b', 'r', 'd', 'k', 't', 'e' };
            Console.WriteLine(string.Join(" ",a));
            CharArraySort s = new CharArraySort();
            Console.WriteLine("  "+String.Join(" ",s.MySortChar(a)));


        }
    }
}

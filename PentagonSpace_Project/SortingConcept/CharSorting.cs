using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.SortingConcept
{
    class CharSorting
    {

        static char[] MysortElelment(char[] a)
        {
            for(char i='a'; i<a.Length; i++)
            {
                for(char j=i; j<a.Length; j++)
                {
                    if(a[i]>a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }

        public static void Main(string[] args)
        {
            char[] arr = { 'b', 'd', 'g', 'k', 'f', 'l' };
            Console.WriteLine(String.Join(" ", arr));
            CharSorting s = new CharSorting();
         
        }
    }
}

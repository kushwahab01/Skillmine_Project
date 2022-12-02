using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.OppsConcept
{
    class EvenNumberArray
    {
        public int FindSum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, 5, 7, 6, 3, 9, 4 };
            EvenNumberArray e = new EvenNumberArray();
            Console.WriteLine( e.FindSum(arr));

        }
    }
}

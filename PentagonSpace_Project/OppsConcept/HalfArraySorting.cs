using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.OppsConcept
{
    class HalfArraySorting
    {
        public int[] Display(int[] arr)
        {
            int b;
            for(int i=0; i<arr.Length; i++)
            {
               for(int j=i+1; j<arr.Length; j++)
                {
                    if (i < arr.Length / 2)
                    {
                        if (arr[i] > arr[j])
                        {
                            b = arr[j];
                            arr[j] = arr[i];
                            arr[i] = b;

                        }
                    }
                    else
                    {
                        if(arr[i]<arr[j])
                        {
                            b = arr[j];
                            arr[j] = arr[i];
                            arr[i] = b;
                        }
                    }
                          
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
                HalfArraySorting s = new HalfArraySorting();
                int[] a = s.Display(arr);
                Console.WriteLine("new array is");
                for(int i=0; i<a.Length; i++)
                {
                    Console.WriteLine(a[i] + " ");
                }

            }
        }
        
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int i;
            
            Console.WriteLine("Input 10 numbers:");
            for (i = 0; i < 10; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe numbers in the array are: ");
            PrintElements(Numbers);
            InsertionSort(Numbers);
            Console.Write("\n Sorted using Insertion: ");
            PrintElements(Numbers);
            Console.ReadKey();
        }
        public static void InsertionSort(int[] Numbers)  //using Insertion Sort
        {
           
            for (int i = 1; i < 10; i++)
            {
                int val = Numbers[i];
                int temp = 0;
                for (int j = i - 1; j >= 0 && temp != 1;)
                {
                    if (val < Numbers[j])
                    {
                        Numbers[j + 1] = Numbers[j];
                        j--;
                        Numbers[j + 1] = val;
                    }
                    else temp = 1;
                }
            }
        }


        public static void PrintElements(int[] Numbers)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", Numbers[i]);
            }
        }
    }
}

using System;

namespace LargestandSmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*find the largest and smallest number in an unsorted integer array*/
            int[] a = { 1, 10, 12, 3, 4 };
            FindLargestSmallestElement(a);
        }
        public static void FindLargestSmallestElement(int[] a)
        {
            int max = a[0];
            int min = a[0];
            for(int i=0; i<a.Length;i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(min +" "+ max);
            Console.WriteLine();

        }
    }
}

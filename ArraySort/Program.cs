using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 67, 39, 8, 61, 74, 82, 97, 27, 56, 49, 58, 79, 86, 14, 3, 23, 37, 92 };
            //int count = 0;
            //for (int i=0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 40)
            //        count += 1;//count tells number of item > 40
            //}
            //int[] brr = new int[count];
            //int index = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 40)
            //    {
            //        brr[index] = arr[i];
            //        index += 1;
            //    }
            //}
            //Array.Sort(brr);
            //Array.Reverse(brr);
            //foreach (int i in brr)
            //    Console.Write(i + " ");
            //    Console.ReadLine();

            //Using LINQ
            var brr = from i in arr where i > 40 orderby i descending select i;
            foreach (int i in brr)
                Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}

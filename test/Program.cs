using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        // Given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
        //For Example:
        //Input: {2, 3, 7, 6, 8, -1, -10, 15}
        //Output: 1
        //Input: { 2, 3, -7, 6, 8, 1, -10, 15 }
        //Output: 4
        //Input: {1, 1, 0, -1, -2}
        //Output: 2
        public static int FindMissing(int[] A)
        {
           var temp = A.Where(x => x > 0).OrderBy(x => x).ToArray();          
            if(temp==null||temp.Length==0)
            {
                return 1;
            }
            var min=temp[0];
            if (min>=2)
            {                
                return 1;
            }           
            int missing = 0;           
            int a=temp.Length;
            for (int i = 1; i < a; i++)
            {
                if (temp[i] == min)
                {
                    continue;
                }
                min++;
                if (temp[i] != min)
                {
                    return min;
                }
               
            }
            if (missing > 0)
            {
                return missing;
            }
            return min + 1;
        }
        static void Main(string[] args)
        {
            //int[] a = new int[40000];
            //for (int i = 2; i < 40000; i++)
            //{
            //    a[i] = i;               
            //}
            int[] a = new int[] { 1, 3, 6, 4, 1, 2 };
            Console.WriteLine(  Program.FindMissing(a));
        
        }
    }
}

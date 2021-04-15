using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode.Easy
{
    public class _350_Intersection_Two_Arrays
    {
        public static void Run()
        {
            var result = Intersect(new int[] { 4,9,5 }
                                    , new int[] {9,4,9,8,4 });
            foreach (var i in result)
            {
                Console.Write($"{i}  ");
            }
            Console.ReadLine();
        }


        public static int[] Intersect(int[] a, int[] b)
         {
            int m = a.Length;
            int n = b.Length;
            int[] result;            
            if (m < n)
            {
                result = Intersect(b, a);
                return result;
            }
            int k = 0;
            int i = 0, j = 0;
            var dic = new HashSet<int>();

            for (i = 0; i < m; i++)
            {
                if (!dic.Contains(a[i]))
                {
                    dic.Add(a[i]);
                }
            }
            for (i = 0; i < n; i++)
            {
                if (dic.Contains(b[i]))
                {
                    a[k++] = b[i];
                }
            }
            result = new int[k];
            for (i = 0; i < k; i++)
            {
                result[i] = a[i];
            }


            return result;
        }
    }
}
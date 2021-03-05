using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMonk
{
    public class Minimum_AND_OR
    {
        public static void Run()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < T; k++)
            {                
                int N = Convert.ToInt32(Console.ReadLine());                
                int[] arr = new int[N];
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                PerformMinimumAndOr(arr);
            }
        }

        private static void PerformMinimumAndOr(int[] arr)
        {            
            int len = arr.Length;
            int min = Int32.MaxValue, res = 0;
            Array.Sort(arr);
            for (int i = 0; i < len-1; i++)
            {                
                res = (arr[i] ^ arr[i+1]);
                if(res < min)
                {
                    min = res;
                }                                
            }
            Console.WriteLine(min);
        }
    }
}

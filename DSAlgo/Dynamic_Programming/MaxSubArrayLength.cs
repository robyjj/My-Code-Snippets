using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Dynamic_Programming
{
    public class MaxSubArrayLength
    {
        public static void Run()
        {
            List<int> arr =  new List<int> { 1,-1,-1,-1,1,1};
            //int n = arr.Length;
            Console.WriteLine("Length of lis is " + maxSubarrayLength(arr) + "\n");
        }

        public static int maxSubarrayLength(List<int> badges)
        {
            int length = badges.Count();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = 1;
            }

            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int product = badges[j] * badges[i];
                    if (product > 0)
                    {
                        arr[i] = arr[j] + 1;
                    }
                }
            }

            return arr.Max();
        }
    }
}

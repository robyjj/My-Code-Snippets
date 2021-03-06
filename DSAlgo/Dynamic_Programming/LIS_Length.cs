using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Dynamic_Programming
{
    /*
     https://www.youtube.com/watch?v=CE2b_-XfVDk
     */
    public static class LIS_Length
    {
        public static void Run()
        {
            int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
            int n = arr.Length;
            Console.WriteLine("Length of lis is " + LongestIncreasingSubsequence(arr, n) + "\n");
        }
        private static int LongestIncreasingSubsequence(int[] arr, int n)
        {
            int[] lis = new int[n];
            for(int i =0;i<n;i++)
            {
                lis[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for(int j = 0;j<i;j++)
                {
                    if(arr[j]< arr[i] && lis[j] + 1 > lis[i])
                    {
                        lis[i] = lis[j] + 1;                       
                    }
                }
            }
            return lis.Max();               
        }
    }
}

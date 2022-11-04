using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode.Easy
{
    class _1991_MiddleIndex
    {
        public static void Run()
        {
            int[] arr = { 2, 3, -1, 8, 4 };            
            Console.WriteLine($"{FindMiddleIndex(arr)}");
        }
        public static int FindMiddleIndex(int[] nums)
        {
            int sum = nums.Sum();
            int n = nums.Length;
            int current = 0;
            for (int i = 0; i < n; i++)
            {
                current += nums[i];
                if (current - nums[i] == sum - current)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}

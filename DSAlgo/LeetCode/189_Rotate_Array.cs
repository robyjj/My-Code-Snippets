using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _189_Rotate_Array
    {
        public static void Run()
        {
            int[] nums = new int[] { 1,2,3,4,5,6,7,8};
            int k = 3;
            RotateArray_Reverse(ref nums, k);
            //RotateArray(ref nums,k);
            nums.ToList().ForEach(n => Console.Write($" {n} "));
            Console.ReadLine();
        }

        private static void RotateArray_Reverse(ref int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            //for (int i =0,j=n-k-1;i<(n-k)/2;i++,j--)
            //{
            //    int temp = nums[i];
            //    nums[i] = nums[j];
            //    nums[j] = temp;
            //}
            //for(int i=n-k,j=n-1;i<(n/2)+ k;i++,j--)
            //{
            //    int temp = nums[i];
            //    nums[i] = nums[j];
            //    nums[j] = temp;
            //}
            Array.Reverse(nums, 0, n - k);
            Array.Reverse(nums, n-k, k);
            Array.Reverse(nums);
        }

        private static void RotateArray(ref int[] nums, int k)
        {
            int len = nums.Length;
            int[] temp = new int[len];
            k = k % len;
            for (int i = 0; i < len; i++)
            {
                if (i < k)
                {
                    temp[i] = nums[len + i - k];
                }
                else
                {
                    temp[i] = nums[i - k];
                }
            }
            nums = temp;
        }
    }
}

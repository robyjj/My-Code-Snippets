using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _283_Move_Zeroes
    {
        public static void Run()
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };            
            MoveZeroes(ref nums);            
            nums.ToList().ForEach(n => Console.Write($" {n} "));
            Console.ReadLine();
        }

        public static void MoveZeroes(ref int[] nums)
        {
            int len = nums.Length;
            int zeroCount = 0, j = 0;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j++] = nums[i];
                }
                else
                {
                    zeroCount++;
                }
            }
            while(zeroCount-- > 0)
            {
                nums[--len] = 0;

            }
        }
    }
}

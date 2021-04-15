using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode.Easy
{
    class _66_PlusOne
    {
        internal static void Run()
        {
            int[] nums = new int[] {8,9,9,9 };
            PlusOne(ref nums);
            nums.ToList().ForEach(n => Console.Write($" {n} "));
            Console.ReadLine();
        }

        private static void PlusOne(ref int[] nums)
        {
            int n = nums.Length;
            int carry;

            nums[n - 1]++;
            carry = nums[n - 1] / 10;
            nums[n - 1] %= 10;

            for(int i = n - 2; i >= 0; i--)
            {
                if(carry == 1)
                {
                    nums[i]++;
                    carry = nums[i] / 10;
                    nums[i] %= 10;
                }
            }

            if(carry == 1)
            {
                Array.Resize(ref nums, n + 1);
                nums[0] = carry;
            }
        }
    }
}

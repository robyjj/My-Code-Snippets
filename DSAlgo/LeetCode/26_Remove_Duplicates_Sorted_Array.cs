using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _26_Remove_Duplicates_Sorted_Array
    {
        public static void Run()
        { 
            int[] nums = new int[] {1,1,2,3,4,4,4 };
            Console.WriteLine(RemoveDuplicates(ref nums));
            Console.ReadLine();
        }

        private static int RemoveDuplicates(ref int[] nums)
        {
            int length = nums.Length;
            if (length == 1 || length == 0)
                return length;
            int j = 0;
            
            for (int i = 1; i < length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[j++] = nums[i - 1];
                }
            }
            nums[j++] = nums[length - 1]; 
            return j;
        }
    }
}

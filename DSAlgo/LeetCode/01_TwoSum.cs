using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._01_Arrays_and_strings
{
    public class TwoSum
    {
        public static void Run()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] result = GetTwoSumIndices(nums, target);
            Console.WriteLine($"[{result[0]},{result[1]}]");
            Console.ReadLine();
        }

        private static int[] GetTwoSumIndices(int[] nums, int target)
        {
            var result = new int[2];
            var numbers = new Dictionary<int,int>();
            int diff  , len = nums.Length;
            for(int i =0;i< len; i++)
            {
                diff = target - nums[i];
                if(numbers.ContainsKey(diff))
                {                    
                    result[0] = i;
                    result[1] = numbers.TryGetValue(diff, out int val) ? val: 0;
                }
                else
                {
                    numbers.Add(nums[i],i);
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode.Easy
{
    class _1013_PartitionArrayInto3Parts
    {
        public static void Run()
        {
            int[] arr = { 1, 3, 4, 0, 4 };
            int n = arr.Length;
            Console.WriteLine($"{CanThreePartsEqualSum(arr)}");
        }

        private static bool CanThreePartsEqualSum(int[] arr)
        {
            int sum = arr.Sum();

            if (sum % 3 != 0)
            {
                return false;
            }

            int sum1 = sum / 3;
            int n = arr.Length;
            int counter = 0;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (counter == 2)
                {
                    return true;
                }
                temp = temp + arr[i];

                if (temp == sum1)
                {
                    counter++;
                    temp = 0;
                }

            }
            return false;
        }
    }
}

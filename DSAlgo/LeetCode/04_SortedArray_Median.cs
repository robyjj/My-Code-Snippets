using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _04_SortedArray_Median
    {
        /// <summary>
        /// 
        /// Find the median of 2 sorted arrays
        /// 
        ///        leftX  rightX
        ///     1   2     9   10
        ///           px
        ///     
        ///     8   12   14  16
        ///            py
        ///        leftY  rightY
        /// </summary>
        public static void Run()
        {
            int[] nums1 = new int[] {1,3,8,9,15 };
            int[] nums2 = new int[] { 7,11,18,19,21,25};
            Console.Write(FindMedianSortedArrays(nums1, nums2));
            Console.ReadLine();
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            int combinedLength = n1 + n2;

            if(n1> n2)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            int low = 0;
            int high = n1;
         

            while(low <= high)
            {
                int px = (low + high) / 2;
                int py = (combinedLength + 1) / 2 - px;

                int LeftX = (px == 0) ? Int32.MinValue:nums1[px - 1];
                int RightX = (px == n1) ? Int32.MaxValue : nums1[px];
                                
                int LeftY = (py == 0) ? Int32.MinValue : nums2[py - 1];
                int RightY = (py == n2) ? Int32.MaxValue : nums2[py];

                if (LeftX <=RightY && LeftY <= RightX)
                {
                    if(combinedLength %2 ==0)
                    {
                        median = (double)(Math.Max(LeftX, LeftY) + Math.Min(RightX,RightY))/ 2;
                    }
                    else
                    {
                        median = (double)Math.Max(LeftX, LeftY);
                    }
                    return median;
                }
                else if(LeftX > RightY)
                {
                    //go to the left

                    high = px - 1;
                }
                else
                {
                    //go to the right
                    low = px + 1;

                }
            }

            return -1;
        }
    }
}

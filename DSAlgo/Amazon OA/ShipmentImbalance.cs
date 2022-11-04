using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Amazon_OA
{
    public class ShipmentImbalance
    {
        public static void Run()
        {
            List<int> arr = new List<int> { 1, -1, -1, -1, 1, 1 };
            Console.Write(printSubArrays(arr.ToArray(), 0, 0, 0));
        }

        static int printSubArrays(int[] arr,
                            int start, int end, int result)
        {
            // Stop if we have reached
            // the end of the array
            if (end == arr.Length)
                return result;

            // Increment the end point
            // and start from 0
            else if (start > end)
                return printSubArrays(arr, 0, end + 1, result);

            // Print the subarray and
            // increment the starting point
            else
            {
                int max = Int32.MinValue, min = Int32.MaxValue;
                //Console.Write("[");
                for (int i = start; i <= end; i++)
                {
                    //Console.Write(arr[i]+", ");
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                //Console.WriteLine(arr[end]+"]");
                //Console.WriteLine(max);
                //Console.WriteLine(min);
                //Console.WriteLine();
                result += (max - min);
                //Console.WriteLine(result);
                return printSubArrays(arr, start + 1, end, result);
            }
            return result;
            //return 0;
        }
    }
}
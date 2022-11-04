using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode.Hard
{
    public class _135_Candy_Distribution
    {
        public static void Run()
        {
            //int[] arr = { 12, 4, 3, 11, 34, 34, 1, 67 };
            //int [] arr = { 1, 5, 7, 3, 1, 9 };
            //int[] arr = { 1, 2, 10, 7, 6, 4, 5, 5, 5, 6 };
            //int[] arr = { 1, 2, 10, 7, 6, 4, 5, 6 };
            int[] arr = { 10,20,15,5,60,70,45,5,15};
            Console.WriteLine("Minimum Candies needed are " + MinCandy(arr) + "\n");
        }

        public static int MinCandy(int[] ratings)
        {
            int n = ratings.Length;
            if (n == 1)
            {
                return 1;
            }
            int[] candies = new int[n];
            for (int i = 0; i < n; i++)
            {
                candies[i] = 1;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (ratings[i + 1] > ratings[i])
                {
                    candies[i + 1] = candies[i] + 1;
                }
            }
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1]
                    && candies[i] < candies[i + 1] + 1)
                {
                    candies[i] = candies[i + 1] + 1;
                }
            }
            return candies.Sum();
        }
    }
}

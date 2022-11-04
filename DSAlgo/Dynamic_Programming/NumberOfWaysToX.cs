using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Dynamic_Programming
{
    class NumberOfWaysToX
    {
        public static void Run()
        {
            int X = 5;
            //Console.WriteLine($"Number of ways to {X} using 1's and 2's  {CountWays(X)} ");
            Console.WriteLine($"Number of ways to {X} using 1's and 2's vis DP  {CountWaysDP(X)} ");
        }

        private static int CountWays(int x)
        {
            if(x == 0 || x == 1)
            {
                return 1;
            }
            else
            {
                return CountWays(x - 1) + CountWays(x - 2);
            }
        }

        private static int CountWaysDP(int x)
        {
            int[] dp = new int[x + 1];
            dp[0] = 1;
            dp[1] = 1;
            //dp[2] = 2;
            for(int i = 2; i <= x; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[x];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _746_MinCostClimingStairs
    {
        public static void Run()
        {
            Console.WriteLine(MinCostClimbingStairs_SlightlyOptimized(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
            Console.WriteLine(MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
            Console.ReadLine();
        }

        private static int MinCostClimbingStairs_SlightlyOptimized(int[] cost)
        {
            int length = cost.Length;
            int[] dp = new int[length];
            int dp0, dp1, dp2;
            dp1 = cost[0];
            dp2 = cost[1];
            for (int i = 2; i < length; i++)
            {
                dp0 = Math.Min(dp1, dp2) + cost[i];
                dp2 = dp1;
                dp1 = dp0;
            }
            return Math.Min(dp1,dp2);
        }

        private static int MinCostClimbingStairs(int[] cost)
        {            
            int length = cost.Length;
            int[] dp = new int[length];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (int i = 2; i < length; i++)
            {
                dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
            }
            return Math.Min(dp[length - 1],dp[length - 2]);
        }
    }
}

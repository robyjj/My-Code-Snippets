using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _1406_StoneGameThree
    {
        
        public static void Run()
        {
            Console.WriteLine(StoneGameIII_Optimized(new int[] { 1, 2, 3, 7 }));
            Console.ReadLine();
        }

        public static string StoneGameIII_Optimized(int[] stoneValue)
        {
            int len = stoneValue.Length;
            int[] dp = new int[len + 1];
            int i = len - 1;
            int i1 = 0, i2=0, i3=0;
            while (i >= 0)
            {
                int ans = int.MinValue;
                ans = Math.Max(ans, stoneValue[i] - i1);
                if (i + 1 < len)
                    ans = Math.Max(ans, stoneValue[i] + stoneValue[i + 1] - i2);
                if (i + 2 < len)
                    ans = Math.Max(ans, stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] - i3);                
                i3 = i2;
                i2 = i1;
                i1 = ans;
                i--;
            }
            if (i1 > 0)
                return "Alice";
            else if (i1 < 0)
                return "Bob";
            else
                return "Tie";
        }

        /// <summary>
        /// dp[i] max relative score at i
        /// For eg : 1,2,3,7
        /// when i =1  ,then s[i] =2 , so ans = 2+3 - dp[i+2] which is 7
        /// </summary>
        public static string StoneGameIII(int[] stoneValue)
        {
            int len = stoneValue.Length;
            int[] dp = new int[len + 1];
            int i = len - 1;
            while(i >= 0)
            {
                int ans = int.MinValue;
                ans = Math.Max(ans, stoneValue[i] - dp[i + 1]);
                if (i + 1 < len)
                    ans = Math.Max(ans, stoneValue[i] + stoneValue[i + 1] - dp[i + 2]);
                if (i + 2 < len)
                    ans = Math.Max(ans, stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] - dp[i + 3]);
                dp[i] = ans;
                i--;
            }
            if (dp[0] > 0)
                return "Alice";
            else if (dp[0] < 0)
                return "Bob";
            else
                return "Tie";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _05_LongestPalindromicSubstring
    {
        public static void Run()
        {           
            Console.WriteLine(LongestPalindrome("cbbaas"));
            Console.ReadLine();
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return String.Empty;
            }
            int len = s.Length;
            int start = 0, end = 0;
            if(len == 1)
            {
                return s;
            }
            else if(len == 2)
            {
                return s.Substring(0,1);
            }
            char[] input = s.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                int len1 = ExpandFromMiddle(input,i,i);
                int len2 = ExpandFromMiddle(input, i, i+1);
                int maxLen = Math.Max(len1, len2);
               
                if(maxLen > end -start)
                {
                    start = i - ((maxLen - 1) / 2);
                    end = i + (maxLen / 2);
                }
            }
            return s.Substring(start,  end - start + 1);
        }

        private static int ExpandFromMiddle(char[] input,int l ,int r)
        {
            if (input == null || l > r)
                return 0;
            int len = input.Length;
            while (l >= 0 && r < len && input[l] == input[r])
            {
                l--;
                r++;
            }
            return r - l - 1;
        }
    }
}

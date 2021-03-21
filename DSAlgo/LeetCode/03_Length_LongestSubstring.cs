using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _03_LongestSubstringLength
    {
        /// <summary>
        /// Have a dictionary of char and its position , if its found in dictionary and within the sliding window move it to index + 1;
        /// </summary>
        public static void Run()
        {
           // Console.WriteLine(LengthOfLongestSubstring("abcabcddabb"));
            Console.WriteLine(LengthOfLongestSubstring_Optimized("abcbbcad"));
            Console.ReadLine();
        }

        public static int LengthOfLongestSubstring_Optimized(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return 0;
            }
            int max = 0;
            Dictionary<char, int> numberList = new Dictionary<char, int>();
            var array = s.ToCharArray();
            int len = s.Length;
            int l = 0, r = 0;
            while (r < len)
            {
                if (numberList.ContainsKey(array[r]))
                {
                    l = Math.Max(numberList[array[r]] + 1, l);
                }

                numberList[array[r]] = r;
                max = Math.Max(r - l + 1, max);
                r++;
            }
            return max;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return 0;
            }
            int max = 0;
            HashSet<int> numberList = new HashSet<int>();
            var array = s.ToCharArray();
            int len = s.Length;
            int l = 0, r = 0;
            while (r < len)
            {
                if (numberList.Contains(array[r]))
                {
                    numberList.Remove(array[l]);
                    l++;
                }
                else
                {
                    numberList.Add(array[r]);
                    r++;
                    max = Math.Max(numberList.Count(), max);
                }
            }
            return max;
        }
    }
}

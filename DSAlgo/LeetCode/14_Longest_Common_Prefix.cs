using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.LeetCode
{
    public class _14_Longest_Common_Prefix
    {
        /// <summary>
        /// Time complexity - O(MN)
        /// N = Number of strings
        /// M = Length of the largest string string
        /// </summary>
        public static void Run()
        {
            Console.WriteLine(LongestCommonPrefix(new string[]  {"geeksforgeeks", "geeks",
                    "geek", "geezer"}));
            Console.ReadLine();
        }

        private static string LongestCommonPrefix(string[] strs)
        {
            int length = strs.Length;
            string prefix = strs[0];
            for(int i =1;i<length;i++)
            {
                prefix = GetCommonPrefix(prefix, strs[i]);

            }
            return prefix;
        }

        private static string GetCommonPrefix(string str1, string str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;
            StringBuilder result = new StringBuilder();
            for(int i =0,j=0;i<n1 && j< n2;i++,j++)
            {
                if(str1[i] != str2[j])
                {
                    break;
                }
                result.Append(str1[i]);
            }
            return result.ToString();
        }
    }
}

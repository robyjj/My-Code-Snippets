using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _738_MonotoneIncreasingDigits
    {
        public static void Run()
        {
            Console.WriteLine(MonotoneIncreasingDigits(10));            
            Console.ReadLine();
        }

        public static int MonotoneIncreasingDigits(int n)
        {
           
            if(CheckIncreasing(n))
            {
                return n;
            }
            else
            {
                while(n-- > 0)
                {
                    if(CheckIncreasing(n))
                    {                       
                        break;
                    }                    
                }
            }
            return n;
        }

        private static bool CheckIncreasing(int n)
        {
            string s_num = Convert.ToString(n);
            int s_len = s_num.Length;
            for (int i = 1; i < s_len; i++)
            {
                if(s_num[i-1] > s_num[i] )
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Dynamic_Programming
{
    public static class UglyNumber
    {
        /*
             Ugly numbers are numbers whose only prime factors are 2, 3 or 5.
                Input  : n = 7
                Output : 8

                Input  : n = 10
                Output : 12

                Input  : n = 15
                Output : 24

                Input  : n = 150
                Output : 5832

                https://www.geeksforgeeks.org/ugly-numbers/
         */
        public static void Run()
        {
            int n = GetNthUglyNumber(150);            
            Console.WriteLine("150th ugly no. is " + n);

            n = GetNthUglyNumber_DP(10);
            Console.WriteLine("10th ugly no. is " + n);
        }


        #region DP
        private static int GetNthUglyNumber_DP(int n)
        {
            int[] ugly = new int[n];
            ugly[0] = 1;
            int i2 = 0, i3 = 0, i5 = 0;
            int next_multiple_2 = 2;
            int next_multiple_3 = 3;
            int next_multiple_5 = 5;
            int next_ugly_num = 1;

            for(int i =1;i<n;i++)
            {
                next_ugly_num = Math.Min(next_multiple_2, Math.Min(next_multiple_3, next_multiple_5));
                ugly[i] = next_ugly_num;

                if(next_ugly_num == next_multiple_2)
                {
                    i2++;
                    next_multiple_2 = ugly[i2] * 2;
                }
                if (next_ugly_num == next_multiple_3)
                {
                    i3++;
                    next_multiple_3 = ugly[i3] * 3;
                }
                if (next_ugly_num == next_multiple_5)
                {
                    i5++;
                    next_multiple_5 = ugly[i5] * 5;
                }
            }

            return next_ugly_num;
        }
        #endregion

        #region Simple Logic
        private static int GetNthUglyNumber(int n)
        {
            int count=1,i=1;
            while(count < n)
            {
                i++;
                if(IsUgly(i))
                {
                    count++;
                }
            }
            return i;
        }

        /*To check if a number is ugly, divide the number by greatest divisible powers of 2, 3 and 5, 
         if the number becomes 1 then it is an ugly number otherwise not. */
        private static bool IsUgly(int n)
        {
            n = MaximumDivisible(n, 2);
            n = MaximumDivisible(n, 3);
            n = MaximumDivisible(n, 5);
            return  (n==1);
        }

        private static int MaximumDivisible(int n, int m)
        {
            while(n % m == 0)
            {
                n /= m;
            }
            return n;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._01_Arrays_and_strings
{
    public class MinDeletionsRightFormat
    {
        public static void Run()
        {
            Console.WriteLine(MinDeletions("BBBAABBBB"));            
            Console.ReadLine();
        }
        public static int MinDeletions(String str)
        {
            int charA = 'A';
            int numB = 0;
            int minDel = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (charA == str[i])
                {
                    minDel = Math.Min(numB, minDel + 1);
                }
                else
                {
                    numB++;
                }
            }
            return minDel;
        }

    }
}

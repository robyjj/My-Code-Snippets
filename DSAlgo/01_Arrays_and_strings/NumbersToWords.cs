using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._01_Arrays_and_strings
{
    public class NumbersToWords
    {

        // strings at index 0 is not used, it is
        // to make array indexing simple
        static string[] one = { "", "one ", "two ", "three ", "four ",
                            "five ", "six ", "seven ", "eight ",
                            "nine ", "ten ", "eleven ", "twelve ",
                            "thirteen ", "fourteen ", "fifteen ",
                            "sixteen ", "seventeen ", "eighteen ",
                            "nineteen " };

        // strings at index 0 and 1 are not used,
        // they is to make array indexing simple
        static string[] ten = { "", "", "twenty ", "thirty ", "forty ",
                            "fifty ", "sixty ", "seventy ", "eighty ",
                            "ninety " };

        public static void Run()
        {
            Console.WriteLine(PrintPasscode(1123456789));
            Console.ReadLine();
        }
        static string PrintPasscode(long n)
        {

            // stores word representation of
            // given number n
            string out1 = "";

            // handles digits at ten millions and
            // hundred millions places (if any)
            out1 += numToWords((int)(n / 10000000),
                               "crore ");

            // handles digits at hundred thousands
            // and one millions places (if any)
            out1 += numToWords((int)((n / 100000) % 100),
                               "lakh ");

            // handles digits at thousands and tens
            // thousands places (if any)
            out1 += numToWords((int)((n / 1000) % 100),
                               "thousand ");

            // handles digit at hundreds places (if any)
            out1 += numToWords((int)((n / 100) % 10),
                               "hundred ");

            if (n > 100 && n % 100 > 0)
            {
                out1 += "and ";
            }

            // handles digits at ones and tens
            // places (if any)
            out1 += numToWords((int)(n % 100), "");

            return out1;
        }

        static string numToWords(int n, string s)
        {
            string str = "";
            if (n > 100)
            {
                str += PrintPasscode(n);
            }
            // if n is more than 19, divide it
            else if (n > 19)
            {
                str += ten[n / 10] + one[n % 10];
            }
            else
            {
                str += one[n];
            }

            // if n is non-zero
            if (n != 0)
            {
                str += s;
            }

            return str;
        }
    }
}

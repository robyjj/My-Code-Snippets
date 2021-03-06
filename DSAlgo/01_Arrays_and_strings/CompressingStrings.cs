using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._01_Arrays_and_strings
{
    public static class CompressingStrings
    {
        /*
         Compresses a string 
        aabbcdddee returns a2b2cd3e2
         
         */
        public static void Run()
        {
            Console.WriteLine(GetCompressedString("abcd"));
            Console.WriteLine(GetCompressedString("aabbcdee"));
        }

        private static string GetCompressedString(string input)
        {
            int count = 1;
            int length = input.Length;
            int compressedSize = CountCompression(input);
            if (compressedSize > length)
            {
                return input;
            }
            StringBuilder sb = new StringBuilder();
            var str = input.ToCharArray();
            char lastChar = str[0];
            for(int i =1; i<length;i++)
            {
                if(lastChar != str[i])
                {
                    sb.Append((char)lastChar + count.ToString());
                    count = 1;
                    lastChar = str[i];
                }
                else
                {
                    count++;                    
                }
            }
            sb.Append((char)lastChar + count.ToString());
            int outputLength = sb.ToString().Length;
            return outputLength >= length ? input : sb.ToString();
        }

        private static int CountCompression(string input)
        {
            int count = 1,size = 0;
            int length = input.Length;           
            var str = input.ToCharArray();
            char lastChar = str[0];
            for (int i = 1; i < length; i++)
            {
                if (lastChar != str[i])
                {   
                    lastChar = str[i];
                    size += 1 + count;
                }
                else
                {
                    count++;
                }
            }
            size += 1 + count;
            return size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class _1054_DistinctBarCodes
    {
        public static void Run()
        {
            var result = RearrangeBarcodes(new int[] { 7, 7, 7, 8, 5, 7, 5, 5, 5, 8 });
            foreach (var i in result)
            {
                Console.Write($"{i}  ");
            }
            Console.ReadLine();
        }
        public static int[] RearrangeBarcodes(int[] barcodes)
        {
            int len = barcodes.Length;
            //if (len == 1) return barcodes;
            int[] result = new int[len];

            Dictionary<int, int> barCodeList = new Dictionary<int, int>();
            int frequentCode = 0, frequentValue = 0;
            for (int i = 0; i < len; i++)
            {
                if (barCodeList.ContainsKey(barcodes[i]))
                {
                    barCodeList[barcodes[i]] = barCodeList[barcodes[i]] + 1;
                }
                else
                {
                    barCodeList[barcodes[i]] = 1;
                }
                if (frequentValue < barCodeList[barcodes[i]])
                {
                    frequentCode = barcodes[i];
                    frequentValue = barCodeList[barcodes[i]];
                }
            }
            barCodeList.Remove(frequentCode);

            int counter = 0;
            while (frequentValue > 0)
            {
                result[counter] = frequentCode;
                frequentValue--;
                counter += 2;
            }
            if (counter >= len)
            {
                counter = 1;
            }
            foreach (KeyValuePair<int, int> entry in barCodeList)
            {
                int freq = entry.Value;
                while (freq > 0)
                {
                    result[counter] = entry.Key;
                    freq--;
                    counter += 2;
                    if (counter >= len)
                    {
                        counter = 1;
                    }

                }
            }
            return result;
        }
    }
}

using System;

namespace CodeMonk
{
    public class MonkRotation
    {
        public static void Run()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < T; k++)
            {
                var input = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(input[0]);
                int K = Convert.ToInt32(input[1]);
                int[] arr = new int[N];
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
               
                PerformRotation(arr,K);
            }
        }

        private static void PerformRotation(int[] arr, int k)
        {
            int p;
            int len = arr.Length;
            k %= len;
            for (int i =0; i < len; i++)
            {
                p = arr[(i + (len - k)) % len];
                Console.Write(p + " ");
            }
            Console.WriteLine();
        }
    }
}

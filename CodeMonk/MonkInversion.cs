using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMonk
{
    public class MonkInversion
    {
        public static void Run()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < T; k++)
            {
                int M = Convert.ToInt32(Console.ReadLine());
                int[][] arr = new int[M][];
                for (int i = 0; i < M; i++)
                {
                    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                }
                CheckInversion(arr,M);
            }
        }

        private static void CheckInversion(int[][] arr, int M)
        {
            int counter = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    for (int p = i; p < M; p++)
                    {
                        for (int q = j; q < M; q++)
                        {
                            if (arr[i][j] > arr[p][q])
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}



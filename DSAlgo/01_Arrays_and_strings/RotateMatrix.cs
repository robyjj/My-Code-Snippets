using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._01_Arrays_and_strings
{
    public static class RotateMatrix
    {
        public static void Run()
        {
            int[,] a = new int[4, 4] {
                { 1,2,3,4},
                { 5,6,7,8},
                { 9,7,6,5 },
                { 2,1,3,2 }
            };
            PrintMatrix(a, 4);
            Transpose(a, 4);
            PrintMatrix(a, 4);
            ReverseRow(a, 4);
            
            //RotateMatrixRight(a, 4);
            PrintMatrix(a, 4);
            Console.ReadLine();
        }

        private static void ReverseRow(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int start = 0;
                int end = n - 1;
                while(start < end)
                {
                    int temp = a[i, start];
                    a[i, start] = a[i, end];
                    a[i, end] = temp;
                    start++;
                    end--;
                }
            }
        }

        private static void Transpose(int[,] a, int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    temp = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = temp;
                }                
            }
            

        }

        private static void PrintMatrix(int[,] a, int n)
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void RotateMatrixRight(int[,] arr, int n)
        {
            int temp;
            for (int i = 0; i < n/2; i++)
            {
                int last = n - 1 - i;
                for (int j = i; j < last; j++)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[j,last];
                    arr[j,last] = arr[last, last];
                    arr[last,last] = arr[last,i];
                    arr[last,i] = temp;
                }
               // PrintMatrix(arr, 4);
            }
          //  PrintMatrix(arr, 4);

        }
    }
}

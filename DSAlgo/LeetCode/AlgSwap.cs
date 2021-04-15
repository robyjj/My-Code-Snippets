using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode
{
    public class AlgSwap
    {
        public static void Run()
        {
            Console.WriteLine(minStep("BBBAAAABBBB"));
            //Console.WriteLine(howManySwaps(new int[] { 101, 758, 315, 730, 472,619, 460, 479}));            
            Console.ReadLine();
        }

        public static int minStep(String str)
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

        public static long howManySwaps(int[] arr)
        {
            int ans = 0;
            int N = arr.Length;
            int[] temp = new int[N];
            Array.Copy(arr, temp, N);
            Array.Sort(temp);
            for (int i = 0; i < N; i++)
            {

                // This is checking whether
                // the current element is
                // at the right place or not
                if (arr[i] != temp[i])
                {
                    ans++;

                    // Swap the current element
                    // with the right index
                    // so that arr[0] to arr[i] is sorted
                    swap(arr, i, indexOf(arr, temp[i]));
                }
            }
            return ans;



            //return swapcount;
        }
        public static void swap( int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static int indexOf(int[] arr, int ele)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ele)
                {
                    return i;
                }
            }
            return -1;
        }

        public static List<string> doesCircleExist(List<string> commands)
        {
            var result = new List<string>();

            char direction = 'N';
            foreach (var command in commands)
            {
                int x = 0, y = 0;
                foreach (var c in command)
                {
                    if (c == 'G')
                    {
                        if (direction == 'N')
                        {
                            y++;
                        }
                        else if (direction == 'S')
                        {
                            y--;
                        }
                        else if (direction == 'W')
                        {
                            x--;
                        }
                        else
                        {
                            x++;
                        }
                    }
                    else if (c == 'L')
                    {
                        if (direction == 'N')
                        {
                            direction = 'W';
                        }
                        else if (direction == 'S')
                        {
                            direction = 'E';
                        }
                        else if (direction == 'W')
                        {
                            direction = 'S';
                        }
                        else
                        {
                            direction = 'N';
                        }
                    }
                    else if (c == 'R')
                    {
                        if (direction == 'N')
                        {
                            direction = 'E';
                        }
                        else if (direction == 'S')
                        {
                            direction = 'W';
                        }
                        else if (direction == 'W')
                        {
                            direction = 'N';
                        }
                        else
                        {
                            direction = 'S';
                        }
                    }
                }
                if (x == 0 && y == 0)
                {
                    result.Add("YES");
                }
                else
                {
                    result.Add("NO");
                }

            }
            return result;

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode.Medium
{
    public class _200_Number_Of_Islands
    {
        public static void Run()
        {
            //char[,] grid = {{'1', '1', '1', '1', '0'},{'1', '1', '0', '1', '0'}, {'1', '1', '0', '0', '0'},{'0', '0', '0', '0', '0'}};
            char[,] grid = { { '1', '1', '0', '0', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '1', '0', '0' }, { '0', '0', '0', '1', '1' } };
       
            Console.WriteLine(NumIslands(grid));
            Console.ReadLine();
        }
        public static int NumIslands(char[,] grid)
        {
            int rows = grid.GetLength(0);
            if(rows == 0)
            {
                return 0;
            }
            int count = 0;
            int cols = grid.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if(grid[i,j] == '1')
                    {
                        count++;
                        dfs(grid, i, j, rows, cols);
                    }
                }
            }
            return count;
        }

        private static void dfs(char[,] grid, int i, int j, int rows, int cols)
        {
            if(i<0 || j<0 || i>=rows ||j>=cols || grid[i,j] != '1')
            {
                return;
            }
            grid[i, j] = '0';
            dfs(grid, i + 1, j, rows, cols);
            dfs(grid, i, j + 1, rows, cols);
            dfs(grid, i - 1, j, rows, cols);
            dfs(grid, i, j - 1, rows, cols);
        }
    }
}

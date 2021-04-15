using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.LeetCode.Medium
{
    /// <summary>
    ///  A logic to check for duplicates in an array
    ///   Traverse the given array from start to end.
    /// For every element in the array increment the arr[i]%n‘th element by n.
    /// Now traverse the array again and print all those indices i for which arr[i]/n is greater than 1. Which guarantees that the number n has been added to that index.
    /// </summary>
    /// This is still work in progress
    public class _36_Valid_Sudoku
    {
        public static void Run()
        {
            char[,] board = new char[9, 9] {
                                            {'5', '3', '.', '.', '7', '.', '.', '.', '.'}
                                            ,{'6', '3', '.', '1', '9', '5', '.', '.', '.'}
                                            ,{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
                                            ,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
                                            ,{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
                                            ,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
                                            ,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
                                            ,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
                                            ,{'.', '.', '.', '.', '8', '.', '.', '7', '9'}
                                        };
            Console.WriteLine(IsValidSudoku(board));
            Console.ReadLine();
        }

        /// This is still work in progress
        public static bool IsValidSudoku(char[,] board)
        {
            int n = 9;
            bool[] numbersRow = new bool[10];
            bool[] numbersColumn = new bool[10];
            bool[,] numbersBox = new bool[10, 10];
            //Validate each Row
            for (int i = 0; i < n; i++)
            {
                /// This is still work in progress
                for (int j = 0; j < n; j++)
                {                 
                    if (board[i, j] != '.')
                    {

                        int currentNum = (int)board[i, j] - '0';
                        if (numbersRow[currentNum])
                        {
                            return false;                            
                        }
                        else
                        {
                            numbersRow[currentNum] = true;
                        }

                        int box_index = (i / 3) * 3 + j / 3;
                        int boxNum = (int)board[i, j] - '0';
                        if (numbersBox[box_index, boxNum])
                        {
                            return false;
                        }
                        else
                        {
                            numbersBox[box_index, boxNum] = true;
                        }
                    }
                    else if(board[j,i] != '.')
                    {
                        int currentNum = (int)board[j, i] - '0';
                        if (numbersColumn[currentNum])
                        {
                            return false;
                        }
                        else
                        {
                            numbersColumn[currentNum] = true;
                        }
                    }
                   
                }
            }

            return true;
        }
    }
}

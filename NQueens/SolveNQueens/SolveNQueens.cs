using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveNQueens
{
    public class SolveNQueens
    {
        public readonly int N;
        private int Steps = 0;
        private List<int[]> ValidSolutions = new List<int[]>();

        public SolveNQueens(int n)
        {
            N = n;
        }

        public void Go()
        {
            int[] board = new int[N + 1];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = 0;
            }

            this.SolveMe(board, 0);
            this.printSolutions();
        }

        public void SolveMe(int[] board, int row)
        {
            if(row == N)
            {
                //store solution
                board[N] = Steps;
                ValidSolutions.Add((int[])board.Clone());
            }
            else
            {
                for (int col = 0; col < N; col++)
                {
                    if (IsSafe(board, row, col))
                    {
                        board[row] = col;
                        Steps++;
                        SolveMe(board, row+1);
                    }
                    //ShiftQueenRight
                }
            }
        }

        public bool IsSafe(int[] board, int row, int col)
        {
            if(row == 0)
            {
                return true;
            }
            else
            {
                for(int i = row - 1; i > -1; i--)
                {
                    int iRow = i;
                    int iCol = board[i];
                    if (Math.Abs(col - iCol) == 0 || Math.Abs(col - iCol) == Math.Abs(row - iRow))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void printSolutions()
        {
            if(ValidSolutions.Count == 0)
            {
                Console.WriteLine($"There are no Valid Solutions where N={N}");
            }
            else
            {
                Console.WriteLine($"There are {ValidSolutions.Count} solution(s) where N={N}. \nThey are as follows\n");
                foreach (var VS in ValidSolutions)
                {
                    Console.WriteLine($"This solution was found in {VS[N]} steps");
                    printBoard(VS);
                }
            }
        }

        private void printBoard(int[] board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (board[i] == j)
                    {
                        Console.Write("Q ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace Sudoku
{
    internal class Program
    {
        static int[,] grid;
        static int N;
        static int k;

        static void Main(string[] args)
        {
            N = 9;
            k = (int)Math.Sqrt(N);
            grid = new int[N, N];

            Console.WriteLine("Enter the Sudoku grid (use 0 for blanks): ");
            for (var i = 0; i < N; i++)
            {
                var row = Console.ReadLine()!.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (row.Length != N)
                {
                    Console.WriteLine($"Invalid input for row {i + 1}. Expected {N} values.");
                    return;
                }

                for (var j = 0; j < N; j++)
                {
                    grid[i, j] = ParseValue(row[j]);
                }
            }

            Console.WriteLine();

            if (SolveSudoku())
            {
                PrintGrid();
            }
            else
            {
                Console.WriteLine("No Solution");
            }
        }

        private static int ParseValue(string val)
        {
            if (val == "0") return 0; 
            return int.Parse(val); 
        }

        private static bool SolveSudoku()
        {
            var (row, col) = FindEmptyCell();
            if (row == -1 && col == -1)
            {
                return true;
            }

            for (var num = 1; num <= N; num++)
            {
                if (IsValid(row, col, num))
                {
                    grid[row, col] = num; 

                    if (SolveSudoku())
                    {
                        return true;
                    }

                    grid[row, col] = 0; 
                }
            }

            return false;
        }

        private static (int row, int col) FindEmptyCell()
        {
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        return (i, j);
                    }
                }
            }

            return (-1, -1);
        }

        private static bool IsValid(int row, int col, int num)
        {
            for (var i = 0; i < N; i++)
            {
                if (grid[row, i] == num)
                {
                    return false;
                }
            }

            for (var i = 0; i < N; i++)
            {
                if (grid[i, col] == num)
                {
                    return false;
                }
            }

            var blockRowStart = (row / k) * k;
            var blockColStart = (col / k) * k;
            for (var i = 0; i < k; i++)
            {
                for (var j = 0; j < k; j++)
                {
                    if (grid[blockRowStart + i, blockColStart + j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void PrintGrid()
        {
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    Console.Write($"{grid[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
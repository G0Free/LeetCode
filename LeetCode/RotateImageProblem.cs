using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RotateImageProblem
    {
        public static void Rotate(ref int[][] matrix)
        {
            int N = matrix.GetLength(0);

            //Transpose the matrix
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    int tmp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = tmp;
                }
            }

            //Swap
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < (N / 2); j++)
                {
                    int tmp = matrix[i][j];
                    matrix[i][j] = matrix[i][(N - j - 1)];
                    matrix[i][(N - j - 1)] = tmp;
                }
            }
        }

        public static void Kiir(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

    }
}

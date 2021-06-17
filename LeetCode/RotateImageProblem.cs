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
            ;
            int resetNumber = (matrix.GetLength(0) - 1);
            int stepNumber = resetNumber;

            int i = 0;
            int j = 0;
            int runnerX = i;
            int runnerY = j;
            int save = matrix[i][j];
            int beirando = matrix[i][j];
            int ctr = 0;

            int starterI = -1;
            int starterJ = -1;

            while (i != starterI || j != starterJ)
            {
                starterI = i;
                starterJ = j;
                //beirando = matrix[i,j];
                beirando = save;
                //search
                while (runnerX < matrix.GetLength(0) && 0 < stepNumber)
                {
                    runnerX++;
                    stepNumber--;
                    if (runnerX == matrix.GetLength(0))
                    {
                        runnerX--;
                    }
                }
                while (runnerY < matrix.GetLength(1) && 0 < stepNumber)
                {
                    runnerY++;
                    stepNumber--;
                    if (runnerY == matrix.GetLength(1))
                    {
                        runnerY--;
                    }
                }
                //end of search

                save = matrix[runnerX][runnerY];
                //matrix[runnerX,runnerY] = matrix[i,j];
                matrix[runnerX][runnerY] = beirando;
                i = runnerX;
                j = runnerY;
                stepNumber = resetNumber;
                //ctr++;
            }
            ;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //SearchInsertProblemSolve();
            //RotateImageProblemSolve();
            //MinimumOperationsProblemSolve();
            //QueriesOnNumberOfPointsInsideACircleProblemSolve();
            ReorderDatainLogFilesProblemSolve();

            Console.ReadLine();

        }

        static void SearchInsertProblemSolve()
        {
            int[] inputArray = { 1, 3, 5, 6 };
            int target = 7;

            int output = 0;
            output = SearchInsertProblem.SearchInsert(inputArray, target);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        static void RotateImageProblemSolve()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] c = { 7, 8, 9 };
            int[][] matrix = { a, b, c };
            RotateImageProblem.Kiir(matrix);
            RotateImageProblem.Rotate(ref matrix);
            Console.WriteLine();
            RotateImageProblem.Kiir(matrix);

            Console.ReadLine();
        }

        static void MinimumOperationsProblemSolve()
        {
            string boxes = "110";
            int[] result = MinimumOperationsProblem.MinOperations(boxes);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + "\t");
            }


            Console.WriteLine();

            Console.ReadLine();
        }

        static void QueriesOnNumberOfPointsInsideACircleProblemSolve()
        {
            /*
            int[] pointA = { 1, 3 };
            int[] pointB = { 3, 3 };
            int[] pointC = { 5, 3 };
            int[] pointD = { 2, 2 };
            int[][] points = { pointA, pointB, pointC, pointD };
           
            int[][] queries = { new int[] { 2, 3, 1 }, new int[] { 4, 3, 1 }, new int[] { 1, 1, 2 } };*/



            int[][] points = { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 3 }, new int[] { 4, 4 }, new int[] { 5, 5 } };
            int[][] queries = { new int[] { 1, 2, 2 }, new int[] { 2, 2, 2 }, new int[] { 4, 3, 2 }, new int[] { 4, 3, 3 } };


            int[] result = QueriesOnNumberOfPointsInsideACircleProblem.CountPoints(points, queries);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + "\t");
            }

            Console.ReadLine();
        }

        static void ReorderDatainLogFilesProblemSolve()
        {
            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };

            logs = ReorderDatainLogFilesProblem.ReorderLogFiles(logs);
            for (int i = 0; i < logs.Length; i++)
            {                
                Console.WriteLine(logs[i]);
                
                
            }
        }
    }//class end
}

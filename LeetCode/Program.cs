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

    }//class end
}

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
            int[] inputArray = { 1, 3, 5, 6 };
            int target = 7;

            int output = 0;
            output = SearchInsertProblem.SearchInsert(inputArray, target);
            Console.WriteLine(output);

            Console.ReadLine();

        }

    }//class end
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    static class MinimumOperationsProblem
    {
        public static int[] MinOperations(string boxes)
        {
            int N = boxes.Length;
            int[] answer = new int[N];

            for (int i = 0; i < N; i++)
            {
                answer[i] = CalculateDistace(i, boxes, N);
            }

            return answer;

        }

        private static int CalculateDistace(int i, string boxes, int N)
        {
            int result = 0;
            ;
            for (int j = 0; j < N; j++)
            {
                if (j != i)
                {
                    if (boxes[j] == '1')
                    {
                        result += Math.Abs(j - i);
                    }
                }
            }
            return result;
        }
    }
}

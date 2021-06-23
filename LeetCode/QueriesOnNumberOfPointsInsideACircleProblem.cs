using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
     You are given an array points where points[i] = [xi, yi] is the coordinates of the ith point on a 2D plane. 
    Multiple points can have the same coordinates.
    You are also given an array queries where queries[j] = [xj, yj, rj] describes a circle centered at (xj, yj) with a radius of rj.
    For each query queries[j], compute the number of points inside the jth circle. 
    Points on the border of the circle are considered inside.
    Return an array answer, where answer[j] is the answer to the jth query.

    */


    static class QueriesOnNumberOfPointsInsideACircleProblem
    {
        static public int[] CountPoints(int[][] points, int[][] queries)
        {
            int queriesLength = queries.GetLength(0);
            int pointsLength = points.GetLength(0);
            int[] result = new int[queriesLength];
            int NumberOfPoints = 0;
            
            for (int j = 0; j < queriesLength; j++)
            {
                NumberOfPoints = 0;
                for (int k = 0; k < pointsLength; k++)
                {
                    if (CalcDistance(points[k][0], points[k][1], queries[j][0], queries[j][1]) <= queries[j][2])
                    {
                        NumberOfPoints++;
                    }
                }
                result[j] = NumberOfPoints;
            }           

            return result;
        }

        static private int CalcDistance(int Ax, int Ay, int Bx, int By)
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2)));
        }
    }
}

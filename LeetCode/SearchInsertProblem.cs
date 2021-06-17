using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SearchInsertProblem
    {

        static public int SearchInsert(int[] nums, int target)
        {
            return LogSearch(0, (nums.Length - 1), nums, target);
        }

        static private int LogSearch(int left, int right, int[] nums, int target)
        {
            if (left < right)
            {
                int center = (int)Math.Round((double)(left + right) / 2);
                if (nums[center] == target)
                {
                    return center;
                }
                else if (nums[center] < target)
                {
                    return LogSearch(left, center - 1, nums, target);
                }
                else if (nums[center] > target)
                {
                    return LogSearch(center + 1, right, nums, target);
                }
                return 0;
            }
            else //the target isnt in the array, so we search the place of it
            {
                int i = 0;
                while (i < nums.Length && nums[i] < target)
                {
                    i++;
                }
                if (i >= nums.Length)
                {
                    return (nums.Length);
                }
                else
                {
                    return i;
                }
            }
        }
    }
}

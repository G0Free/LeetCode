using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*/Given a sorted array of distinct integers and a target value, 
     * return the index if the target is found. 
     * If not, return the index where it would be if it were inserted in order.

     You must write an algorithm with O(log n) runtime complexity.

     Example 1:

     Input: nums = [1, 3, 5, 6], target = 5
         Output: 2
     Example 2:


         Input: nums = [1, 3, 5, 6], target = 2
         Output: 1
     Example 3:


         Input: nums = [1, 3, 5, 6], target = 7
         Output: 4
     Example 4:


         Input: nums = [1, 3, 5, 6], target = 0
         Output: 0
     Example 5:


     Input: nums = [1], target = 0
     Output: 0

------
     Constraints:

         1 <= nums.length <= 104
         -104 <= nums[i] <= 104
         nums contains distinct values sorted in ascending order.
         -104 <= target <= 104 
         */
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //You are given two non-empty linked lists representing two non-negative integers.
    //The digits are stored in reverse order, and each of their nodes contains a single digit.
    //Add the two numbers and return the sum as a linked list.
    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    //Input: l1 = [2,4,3], l2 = [5,6,4]
    //Output: [7,0,8]
    //Explanation: 342 + 465 = 807.

    class AddTwoNumbersProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int number1 = ListToInt(l1);
            int number2 = ListToInt(l2);

            int intResult = number1 + number2;
            string tmp = intResult.ToString();
            

            for (int i = tmp.Length-1; 0 < i; i--)
            {
                int.Parse(tmp[i].ToString());
            }

            return null;
        }

        private int ListToInt(ListNode listNode)
        {
            string tmp = "";
            while (listNode.next != null)
            {
                tmp = listNode.val + tmp;
            }
            return int.Parse(tmp);
        }        
    }
}

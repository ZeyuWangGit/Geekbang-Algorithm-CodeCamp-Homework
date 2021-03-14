using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Practice
{
    // 21. 合并两个有序链表
    public class Question21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode preHead = new ListNode(-1);
            ListNode prev = preHead;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }
            prev.next = l1 == null ? l2 : l1;
            return preHead.next;
        }
    }
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
}

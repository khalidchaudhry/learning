﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterviewQuestions.Easy
{
    class _21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode headNode = null;
            ListNode tailNode = null;
            ListNode tempNode = null;

            if (l1 != null && (l2 == null || l1.val < l2.val))
            {
                headNode = tailNode = new ListNode(l1.val);
                l1 = l1?.next;
            }
            else
            {
                headNode = tailNode = new ListNode(l2.val);
                l2 = l2.next;
            }

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    tempNode = new ListNode(l1.val);
                    tailNode.next = tempNode;
                    tailNode = tempNode;
                    l1 = l1.next;
                }
                else if (l2.val < l1.val)
                {
                    tempNode = new ListNode(l2.val);
                    tailNode.next = tempNode;
                    tailNode = tempNode;
                    l2 = l2.next;
                }
                else
                {
                    tempNode = new ListNode(l1.val);
                    tailNode.next = tempNode;
                    tailNode = tempNode;
                    l1 = l1.next;


                    tempNode = new ListNode(l2.val);
                    tailNode.next = tempNode;
                    tailNode = tempNode;
                    l2 = l2.next;
                }

            }

            while (l1 != null)
            {
                tempNode = new ListNode(l1.val);
                tailNode.next = tempNode;
                tailNode = tempNode;
                l1 = l1.next;

            }

            while (l2 != null)
            {
                tempNode = new ListNode(l2.val);
                tailNode.next = tempNode;
                tailNode = tempNode;

                l2 = l2.next;
            }

            return headNode;
        }


        public ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {

            ListNode dummyNode = new ListNode(0);
            ListNode endOfSortedList = dummyNode;



            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    //doing a rewiring to ensure that end of sorted list points to the  node with lesser value
                    endOfSortedList.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    endOfSortedList.next = l2;
                    l2 = l2.next;

                }

                endOfSortedList = endOfSortedList.next;
            }

            if (l1 == null)
            {
                endOfSortedList.next = l2;
            }

            if (l2 == null)
            {
                endOfSortedList.next = l1;
            }

            return dummyNode.next;

        }
    }
}

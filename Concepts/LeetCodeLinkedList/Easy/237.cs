﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLinkedList.Easy
{
    class _237
    {
        public void DeleteNode(ListNode node)
        {

            node.val = node.next.val;

            node.next = node.next.next;

        }

    }
}

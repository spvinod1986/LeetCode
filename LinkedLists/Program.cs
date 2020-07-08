using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solutions
    {
        // Problem : Reverse a singly linked list.
        public ListNode ReverseListIterative(ListNode head)
        {
            if (head == null)
                return head;

            var previous = head;
            var current = head.next;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            head.next = null;
            return previous;
        }

        public ListNode ReverseListRecursive(ListNode head)
        {
            if (head == null)
                return head;

            return ReverseList(null, head);
        }

        private ListNode ReverseList(ListNode previous, ListNode current)
        {
            if (current == null)
                return previous;

            var next = current.next;
            current.next = previous;

            return ReverseList(current, next);
        }

        // Problem: Merge Two Sorted Lists
        // Merge two sorted linked lists and return it as a new sorted list. 
        // The new list should be made by splicing together the nodes of the first two lists.
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            var root = result;

            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            while (l1 != null && l2 != null)
            {
                if (l2.val > l1.val)
                {
                    result.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    result.next = l2;
                    l2 = l2.next;
                }
                result = result.next;
            }

            if (l1 != null)
            {
                result.next = l1;
            }

            if (l2 != null)
            {
                result.next = l2;
            }
            return root.next;
        }

        //Definition for singly-linked list.
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
}

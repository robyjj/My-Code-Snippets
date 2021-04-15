using DSAlgo._02_Linked_Lists;
using System;
using System.Collections.Generic;
using static DSAlgo._02_Linked_Lists.MyLinkedList;
namespace DSAlgo.LeetCode.Easy
{
    public class _234_Palindrome_LinkedList
    {
        /// <summary>
        /// 
        /// using a Stack
        /// 
        /// 1 -> 2 -> 2 -> 1
        /// 
        /// 1 -> 2 -> 3 -> 2 -> 1
        /// 
        /// </summary>
        public static void Run()
        {
            MyLinkedList list1 = new MyLinkedList();
            list1.head = new Node(1);
            list1.head.next = new Node(2);
            list1.head.next.next = new Node(3);
            list1.head.next.next.next = new Node(2);
            list1.head.next.next.next.next = new Node(1);
            bool result = IsPalindrome(list1.head);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static bool IsPalindrome(Node head)
        {
            if (head == null) return false;
            Stack<int> numbers = new Stack<int>();
            Node sp = head;
            Node fp = head;

            while (fp != null && fp.next != null)
            {
                fp = fp.next.next;
                numbers.Push(sp.data);
                sp = sp.next;
            }
            //handle odd number of nodes
            if (fp != null && fp.next == null)
            {
                sp = sp.next;
            }

            while (sp != null)
            {
                if (sp.data != numbers.Pop())
                {
                    return false;
                }
                sp = sp.next;
            }
            return true;

        }
    }
}

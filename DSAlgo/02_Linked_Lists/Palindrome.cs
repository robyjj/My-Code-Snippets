using System;
using System.Collections.Generic;
using static DSAlgo._02_Linked_Lists.MyLinkedList;

namespace DSAlgo._02_Linked_Lists
{
    public static class Palindrome
    {
        public static void Run()
        {
            MyLinkedList list = new MyLinkedList();
            list.head = new Node(10);
            list.head.next = new Node(12);
            list.head.next.next = new Node(21);
            list.head.next.next.next = new Node(1);
            list.head.next.next.next.next = new Node(21);
            list.head.next.next.next.next.next = new Node(12);
            list.head.next.next.next.next.next.next = new Node(10);
            PrintList(list.head);
            if (IsPalindrome(list.head))
                Console.WriteLine("Its a Palindrome");
            else
                Console.WriteLine("Its not a palindrome");

            list.head = new Node(10);
            list.head.next = new Node(12);
            list.head.next.next = new Node(21);
            list.head.next.next.next = new Node(21);
            list.head.next.next.next.next = new Node(12);
            list.head.next.next.next.next.next = new Node(10);            
            PrintList(list.head);
            if (IsPalindrome(list.head))
                Console.WriteLine("Its a Palindrome");
            else
                Console.WriteLine("Its not a palindrome");

            list.head = new Node(10);
            list.head.next = new Node(12);
            list.head.next.next = new Node(21);
            list.head.next.next.next = new Node(21);
            list.head.next.next.next.next = new Node(12);
            list.head.next.next.next.next.next = new Node(12);
            PrintList(list.head);
            if (IsPalindrome(list.head))
                Console.WriteLine("Its a Palindrome");
            else
                Console.WriteLine("Its not a palindrome");

            Console.ReadKey();
        }

        private static bool IsPalindrome(Node head)
        {
            if (head == null) return false;
            Stack<int> stack = new Stack<int>();
            Node slow = head, fast = head;
            while(fast != null && fast.next != null)
            {
                stack.Push(slow.data);
                slow = slow.next;
                fast = fast.next.next;
            }
            if(fast != null)
            {
                slow = slow.next;
            }
            while(slow != null)
            {
                if(stack.Pop() != slow.data)
                {
                    return false;
                }
                slow = slow.next;
            }
            return true;
        }

    }
}

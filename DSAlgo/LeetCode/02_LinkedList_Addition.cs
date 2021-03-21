using DSAlgo._02_Linked_Lists;
using System;
using static DSAlgo._02_Linked_Lists.MyLinkedList;

namespace DSAlgo.LeetCode
{
    public class _02_LinkedList_Addition
    {
        public static void Run()
        {
            MyLinkedList list1 = new MyLinkedList();
            list1.head = new Node(2);
            list1.head.next = new Node(4);
            list1.head.next.next = new Node(5);
            MyLinkedList list2 = new MyLinkedList();
            list2.head = new Node(5);
            //list2.head.next = new Node(6);
            //list2.head.next.next = new Node(4);
            PrintList(list1.head);
            PrintList(list2.head);
            Node result = AddTwoNumbers(list1.head, list2.head);
            Console.ReadLine();
        }

        public static Node AddTwoNumbers(Node l1, Node l2)
        {
            Node result = null;
            Node prev = null;
            Node temp = null;
            int sum=0 ;
            if(l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            while (l1 != null || l2 != null)
            {
                if(l1 != null)
                {
                    sum += l1.data;
                    l1 = l1.next;
                }
                if(l2 != null)
                {
                    sum += l2.data;
                    l2 = l2.next;
                }
               
                temp = new Node(sum % 10, null);
                sum /= 10;
                if (result == null)
                {
                    result = temp;
                }
                else
                {
                    prev.next = temp;
                }

                prev = temp;
            
            }
            if (sum > 0)
            {
                temp.next = new Node(sum, null);
            }
            return result;
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

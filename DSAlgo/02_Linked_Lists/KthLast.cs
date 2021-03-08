using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSAlgo._02_Linked_Lists.MyLinkedList;

namespace DSAlgo._02_Linked_Lists
{
    /*Find the Kth last element in a linked list
     have 2 pointers placed at a distance -k , move the 2nd pt till null , return the 1st ptr.next 
     */
    public static class KthLast
    {
        public static void Run()
        {
            MyLinkedList list = new MyLinkedList();
            list.head = new Node(10);
            list.head.next = new Node(12);
            list.head.next.next = new Node(21);
            list.head.next.next.next = new Node(1);
            list.head.next.next.next.next = new Node(7);
            list.head.next.next.next.next.next = new Node(30);
            list.head.next.next.next.next.next.next = new Node(5);
            PrintList(list.head);
            int k = 78;
            var kthNode = FindKthLastElement(list,k);
            Console.WriteLine(kthNode?.data);
            Console.ReadLine();
        }

        private static Node FindKthLastElement(MyLinkedList list,int k )
        {
            if (list == null || k <= 0) return null;
            Node p1 = list.head;
            Node p2 = list.head;
            while(k>1)
            {
                if(p2 == null)
                {
                    return null;
                }
                p2 = p2.next;
                k--;
            }
            if (p2 == null)
            {
                return null;
            }
            while (p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }

            return p1;
        }
    }
}

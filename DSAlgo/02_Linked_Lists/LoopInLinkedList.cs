using System;
using static DSAlgo._02_Linked_Lists.MyLinkedList;

namespace DSAlgo._02_Linked_Lists
{
    public static class LoopInLinkedList
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
            
            Console.WriteLine(BeginningOfLoop(list)?.data);
            list.head.next.next.next.next.next.next.next = list.head.next;
            Console.WriteLine(BeginningOfLoop(list)?.data);
            Console.ReadLine();
        }

        private static Node BeginningOfLoop(MyLinkedList list)
        {
            Node p1 = list.head, p2 = list.head;
            while(p2 != null && p2.next!= null)
            {
                p1 = p1.next;
                p2 = p2.next.next;

                if(p1 == p2)
                {
                    break;
                }
            }
            if(p2 == null || p2.next == null)
            {
                Console.WriteLine("There is no loop in the Linked List");
                return null;
            }
            p1 = list.head;
            while(p1 != p2)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            return p2;
        }
    }
}

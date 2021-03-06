using System;

namespace DSAlgo._02_Linked_Lists
{
    public class MyLinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d, Node next = null)
            {
                this.data = d;
                this.next = next;                
            }
        }
        public static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }

}

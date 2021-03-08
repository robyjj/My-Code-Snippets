using System;
using System.Collections.Generic;
using static DSAlgo._02_Linked_Lists.MyLinkedList;

namespace DSAlgo._02_Linked_Lists
{
    public class RemoveDuplicates
    {
        /* Removes duplicates from an unsorted Linked List*/
        public static void Run()
        {
            MyLinkedList list = new MyLinkedList();
            list.head = new Node(10);
            list.head.next = new Node(12);
            list.head.next.next = new Node(11);
            list.head.next.next.next = new Node(11);
            list.head.next.next.next.next = new Node(12);
            list.head.next.next.next.next.next = new Node(11);
            list.head.next.next.next.next.next.next = new Node(10);
            PrintList(list.head);
            RemoveDuplicatesUsingDictionary(list);
            PrintList(list.head);

            //PrintList(list.head);
            //RemoveDuplicatesWithoutBuffer(list);
            //PrintList(list.head);
            Console.ReadLine();
        }

        private static void RemoveDuplicatesUsingDictionary(MyLinkedList list)
        {
            //Dictionary<int, int> listInfo = new Dictionary<int, int>();
            HashSet<int> listInfo = new HashSet<int>();
            Node current = list.head;
            Node prev = null;
            while(current != null)
            {
                if (listInfo.Contains(current.data))
                {
                    prev.next = current.next;
                }
                else
                {
                    listInfo.Add(current.data);
                    prev = current;
                }
                current = current.next;
            }

        }

        private static void RemoveDuplicatesWithoutBuffer(MyLinkedList list)
        {            
            Node ptr1 = null;
            Node ptr2 = null;            
            ptr1 = list.head;
            while(ptr1 != null && ptr1.next != null)
            {
                ptr2 = ptr1;
                while(ptr2.next != null)
                {
                    if(ptr1.data == ptr2.next.data)
                    {
                        //duplicate present                        
                        ptr2.next = ptr2.next.next;
                    }
                    else
                    {
                        ptr2 = ptr2.next;
                    }    
                }
                ptr1 = ptr1.next;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._03_Stacks_and_Queues
{ 
    /* Implement a Queeu using a Stack*/
    public static class QueueUsingStack
    {
        public static void Run()
        {
            MyQueue<int> myQ = new MyQueue<int>();
            myQ.Enqueue(10);
            myQ.Enqueue(50);
            myQ.Enqueue(30);
            myQ.Enqueue(40);
            myQ.Enqueue(77);
            Console.WriteLine(myQ.Dequeue());
            Console.WriteLine(myQ.Dequeue());
            Console.WriteLine(myQ.Peek());
            Console.WriteLine(myQ.Dequeue());
            Console.ReadLine();
        }
    }
    public class MyQueue<T>
    {
        Stack<T> stackNew = new Stack<T>();
        Stack<T> stackOld = new Stack<T>();

        public void Enqueue(T data)
        {
            stackNew.Push(data);
        }
        public T Dequeue()
        {            
            ShiftStacks();
            return stackOld.Pop(); 
        }
        public T Peek()
        {
            ShiftStacks();
            return stackOld.Peek();
        }

        /*If old stack is empty , transfer all elements from new stack to old stack*/
        public void ShiftStacks()
        {
            if(!stackOld.Any())
            {
                while(stackNew.Any())
                {
                    stackOld.Push(stackNew.Pop());
                }
            }
        }
    }
}

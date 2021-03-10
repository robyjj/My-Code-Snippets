using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._03_Stacks_and_Queues
{
    /*Creating a custom stack where push,pop and getMin with run at O(1)*/
    public static class StackMin
    {
        public static void Run()
        {

        }
    }

    public class MyCustomStack : Stack<int>
    {
        int top = -1;
        int[] elements;
        int max;
        Stack<int> minStack = new Stack<int>();

        public MyCustomStack(int size)
        {
            elements = new int[size];
            max = size;
        }
        public void Push(int data)
        {
            if(data < GetMin())
            {
                minStack.Push(data);
            }
            base.Push(data);

        }
        public int Pop()
        {
            int poppedElement = base.Pop();
            if (poppedElement == GetMin())
            {
                minStack.Pop();
            }
            return poppedElement;
        }
        public int GetMin()
        {
            if(minStack.Any())
            {
                return minStack.Peek();
            }
            return int.MaxValue;
        }
    }
}

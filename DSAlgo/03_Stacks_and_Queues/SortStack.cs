using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._03_Stacks_and_Queues
{
    /* Sorting elements in a stack*/
    public static class SortStack
    {
        public static void Run()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(20);
            stack.Push(30);
            stack.Push(10);
            stack.Push(50);
            stack.Push(25);
            Sort(stack);
        }

        private static void Sort(Stack<int> stack)
        {
            Stack<int> tempStack = new Stack<int>();
            while(stack.Any())
            {
                int element = stack.Pop();
                while(tempStack.Any() && element < tempStack.Peek())
                {
                    stack.Push(tempStack.Pop());
                }
                tempStack.Push(element);
            }
            
        }
    }
}

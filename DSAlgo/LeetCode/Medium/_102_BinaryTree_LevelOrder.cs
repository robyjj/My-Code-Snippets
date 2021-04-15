using System;
using System.Collections.Generic;
using DSAlgo._04_Trees_and_Graphs;

namespace DSAlgo.LeetCode.Medium
{
    class _102_BinaryTree_LevelOrder
    {
        public static void Run()
        {
            Tree tree = new Tree();
            tree.root = new Node(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(5);
           
            var result = LevelOrder(tree.root);
          
            Console.ReadLine();
        }

        public static IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return null;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                List<int> level = new List<int>();
                int size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    Node t = q.Dequeue();
                    level.Add(t.data);
                    if (t.Left != null)
                    {
                        q.Enqueue(t.Left);
                    }
                    if (t.Right != null)
                    {
                        q.Enqueue(t.Right);
                    }
                }

                result.Add(level);
            }
            return result;
        }
    }
}

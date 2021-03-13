using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._04_Trees_and_Graphs
{
    public static class TreeTraversal
    {
        public static void Run()
        {
            Tree tree = new Tree();
            tree.root = new Node(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(5);
            Console.WriteLine("\nInorder Traversal");
            Inorder(tree.root);
            Console.WriteLine("\nPreOrder Traversal");
            PreOrder(tree.root);
            Console.WriteLine("\nPostOrder Traversal");
            PostOrder(tree.root);

            Console.ReadLine();
        }

        private static void Inorder(Node root)
        {
            if(root == null)
            {
                return;
            }
            Inorder(root.Left);
            Console.Write($"{root.data} ");
            Inorder(root.Right);
        }

        private static void PreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write($"{root.data} ");
            PreOrder(root.Left);            
            PreOrder(root.Right);
        }

        private static void PostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write($"{root.data} ");
        }
    }
}

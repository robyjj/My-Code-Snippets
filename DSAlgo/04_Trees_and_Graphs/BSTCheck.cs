using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._04_Trees_and_Graphs
{
    /// <summary>
    /// Check if the given Binary tree is a Binary Search Tree
    /// </summary>
    public class BSTCheck
    {
        static int Min_Value = Int32.MinValue;
        public static void Run()
        {
            Tree tree = new Tree();
            tree.root = new Node(4);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(5);
            tree.root.Left.Left = new Node(1);
            tree.root.Left.Right = new Node(3);
            tree.Size = 5;

            Console.WriteLine((CheckIfBSTUtil(tree.root, tree.Size) == true) ? "Is a BST" : "Not a BST");

            tree = new Tree();
            tree.root = new Node(20);
            tree.root.Left = new Node(10);
            tree.root.Right = new Node(30);            
            tree.root.Left.Right = new Node(25);
            tree.Size = 4;

            Console.WriteLine((CheckIfBSTUtil(tree.root, tree.Size) == true) ? "Is a BST" : "Not a BST");

            Console.ReadLine();
        }

        private static bool CheckIfBSTUtil(Node root,int Size)
        {
            int[] a = new int[Size];
            return CheckIfBST(root);
          
        }

        private static bool CheckIfBST(Node root)
        {   
            if(root == null)
            {
                return true;
            }
            CheckIfBST(root.Left);
            if(root.data < Min_Value)
            {
                return false;
            }
            else
            {
                Min_Value = root.data;
            }            
            CheckIfBST(root.Right);
            return true;
        }
    }
}

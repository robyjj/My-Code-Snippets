using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._04_Trees_and_Graphs
{
    public class Node
    {
        public int data { get; set; }
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }
    }

    public class Tree
    {
        public Node root;
        public int Size;
        public Tree()
        {
            root = null;
        }
    }
}

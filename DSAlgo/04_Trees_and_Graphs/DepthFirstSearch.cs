using System;
using System.Collections.Generic;

namespace DSAlgo._04_Trees_and_Graphs
{
    public static class DepthFirstSearch
    {

        static Graph g;
        public static void Run()
        {
            int V = 4;
            g = new Graph(V);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            int node = 2;
            DFSUtil(node, V);
            Console.ReadLine();
        }

        private static void DFSUtil(int node, int V)
        {
            Console.WriteLine("Recursive : ");
            bool[] visited = new bool[V];
            DFS_Recursive(node, visited);

            Console.WriteLine("\nIterative : ");
            visited = new bool[V];
            for (int i = 0; i < V; i++)
                if (!visited[i])
                    DFS_Iterative(i, visited);

        }

        private static void DFS_Iterative(int v, bool[] visited)
        {
            Stack<int> items = new Stack<int>();
            items.Push(v);
            while (items.Count > 0)
            {
                v = items.Pop();
                if (!visited[v])
                {
                    Console.Write($"{v} ");
                    visited[v] = true;
                }
                var list = g.adj[v];
                foreach (var n in list)
                {
                    if (!visited[n])
                    {
                        items.Push(n);
                    }
                }
            }
        }

        private static void DFS_Recursive(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write($"{v} ");

            var list = g.adj[v];
            foreach (var n in list)
            {
                if (!visited[n])
                {
                    DFS_Recursive(n, visited);
                }
            }

        }
    }
}
